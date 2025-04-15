using SmartExpenseTracker.API.Models;

namespace SmartExpenseTracker.API.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllAsync();
        Task AddAsync(Category category);
        Task<bool> ExistsAsync(string name);
    }
}
