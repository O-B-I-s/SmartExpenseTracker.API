using Microsoft.EntityFrameworkCore;
using SmartExpenseTracker.API.Data;
using SmartExpenseTracker.API.Models;

namespace SmartExpenseTracker.API.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task AddAsync(Category category)
        {
            _context.Categories.Add(category);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> ExistsAsync(string name)
        {
            return await _context.Categories.AnyAsync(c => c.Name == name);
        }
    }
}
