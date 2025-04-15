using Microsoft.Extensions.ML;
using Microsoft.ML;
using SmartExpenseTracker.API.Data;
using SmartExpenseTracker.API.Models;

namespace SmartExpenseTracker.API.Services
{
    public class ExpenseCategorizationService
    {
        private readonly MLContext _mlContext;
        private readonly ApplicationDbContext _context;
        private ITransformer _model;
        private PredictionEnginePool<Expense, CategoryPrediction> _predictionEnginePool;

        public ExpenseCategorizationService(ApplicationDbContext context, PredictionEnginePool<Expense, CategoryPrediction> predictionEnginePool)
        {
            _predictionEnginePool = predictionEnginePool ?? throw new ArgumentNullException(nameof(predictionEnginePool));


        }



        public string PredictCategories(string description)
        {

            if (_predictionEnginePool == null)
            {
                Console.WriteLine("Prediction enginePool is null");
            }
            var prediction = _predictionEnginePool.Predict(new Expense { Description = description });
            //return prediction.PredictedCategory.Split(',').ToList();
            return prediction?.PredictedCategory ?? "Uncategorized";
        }



        public string CategorizeExpense(string description)
        {
            if (_predictionEnginePool == null)
            {
                return "Uncategorized";
            }

            var prediction = _predictionEnginePool.Predict(new Expense { Description = description });
            return prediction.PredictedCategory;
        }
    }
}
