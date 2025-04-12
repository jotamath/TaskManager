using Microsoft.EntityFrameworkCore;
using TaskManager.Domain.Entities;
using TaskManager.Domain.Repositories;
using TaskManager.Infrastructure.Persistence;

namespace TaskManager.Infrastructure.Repositories;

public class CategoryRepository : ICategoryRepository
{
    private readonly TaskDbContext _context;

    public CategoryRepository(TaskDbContext context) 
    {
        _context = context;
    }

    public async Task AddAsync(Category category) {
        await _context.Categories.AddAsync(category);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id) {
        var category = await _context.Categories.FindAsync(id);
        if (category is null) return;

        _context.Categories.Remove(category);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Category>> GetAllAsync() {
        return await _context.Categories.Include(c => c.Tasks).ToListAsync();
    }

    public async Task<Category?> GetByIdAsync(Guid id) {
        return await _context.Categories.Include(c => c.Tasks).FirstOrDefaultAsync(c => c.Id == id);
    }

    public async Task UpdateAsync(Category category) {
        _context.Categories.Update(category);
        await _context.SaveChangesAsync();
    }
}