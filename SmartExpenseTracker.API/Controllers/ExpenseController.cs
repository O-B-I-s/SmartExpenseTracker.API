using Microsoft.AspNetCore.Mvc;
using SmartExpenseTracker.API.Models;
using SmartExpenseTracker.API.Repositories;
using SmartExpenseTracker.API.Services;

namespace SmartExpenseTracker.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    //[Authorize]
    public class ExpenseController : ControllerBase
    {
        private readonly IExpenseRepository _repository;
        private readonly ExpenseCategorizationService _categorizationService;

        public ExpenseController(IExpenseRepository repository, ExpenseCategorizationService categorizationService)
        {
            _repository = repository;
            _categorizationService = categorizationService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            var expenses = await _repository.GetAllAsync();
            return Ok(expenses);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var expense = await _repository.GetByIdAsync(id);
            if (expense == null) return NotFound();
            return Ok(expense);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Expense expense)
        {
            var predictedCategories = _categorizationService.PredictCategories(expense.Description);
            if (expense.Category == null || string.IsNullOrEmpty(expense.Category))
            {
                expense.Category = predictedCategories;
            }


            await _repository.AddAsync(expense);


            return CreatedAtAction(nameof(GetById), new { id = expense.Id }, expense);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Expense expense)
        {
            if (id != expense.Id) return BadRequest();

            var predictedCategories = _categorizationService.PredictCategories(expense.Description);
            if (expense.Category == null || string.IsNullOrEmpty(expense.Category))
            {
                expense.Category = predictedCategories;
            }

            await _repository.UpdateAsync(expense);
            //_categorizationService.RetrainModel(); // Retrain after updating

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _repository.DeleteAsync(id);
            //_categorizationService.RetrainModel(); // Retrain after deleting

            return NoContent();
        }
    }
}
