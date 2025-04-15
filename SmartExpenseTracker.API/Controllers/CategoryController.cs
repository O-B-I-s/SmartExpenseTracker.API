using Microsoft.AspNetCore.Mvc;
using SmartExpenseTracker.API.Models;
using SmartExpenseTracker.API.Repositories;

namespace SmartExpenseTracker.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    //[Authorize]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categories = await _categoryRepository.GetAllAsync();

            var modelPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "model.zip");
            Console.WriteLine($"Model path: {modelPath}");
            if (!System.IO.File.Exists(modelPath))
            {
                Console.WriteLine("Model file does not exist.");
            }


            return Ok(categories);

        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Category category)
        {

            if (string.IsNullOrWhiteSpace(category.Name))
                return BadRequest("Category name is required");

            var exists = await _categoryRepository.ExistsAsync(category.Name);
            if (exists)
                return Conflict("Category already exists");

            await _categoryRepository.AddAsync(category);
            return CreatedAtAction(nameof(GetAll), new { id = category.Id }, category);
        }
    }
}
