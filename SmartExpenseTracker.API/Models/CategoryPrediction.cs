using Microsoft.ML.Data;

namespace SmartExpenseTracker.API.Models
{
    public class CategoryPrediction
    {
        [ColumnName("PredictedLabel")]
        public string PredictedCategory { get; set; }
    }
}
