using Microsoft.EntityFrameworkCore;
using TODO.Models.Entities;
using TODO.Repository;

namespace todo.Services;

public class TodoService(ApplicationDbContext dbContext) : ITodoService
{
    public async Task<(List<Todo> Todos, int TotalCount)> GetTodos(int page, int pageSize)
    {
        var totalCount = await dbContext.Todos.CountAsync();
        return (await dbContext.Todos.Skip(page * pageSize).Take(pageSize).ToListAsync(), totalCount);
    }
}