using TODO.Models.Entities;

namespace todo.Services;

public interface ITodoService
{
    Task<(List<Todo> Todos, int TotalCount)> GetTodos(int page, int pageSize);
}