using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using TODO.Models;
using TODO.Models.Entities;
using todo.Services;

namespace todo.Controllers;

[ApiController]
[EnableCors("AnyPolicy")]
[Route("api/[controller]")]
public class TodoController(ILogger<TodoController> logger, ITodoService todoService) : ControllerBase
{
  [HttpGet]
  public async Task<IActionResult> Get([FromQuery] int page, [FromQuery] int pageSize)
  {
    var (todos, totalCount) = await todoService.GetTodos(page, pageSize);
    return Ok(new ApiResponse<List<Todo>>
    {
      Data = todos,
      Metadata = new MetaData
      {
        Page = page,
        PageSize = pageSize,
        TotalCount = totalCount
      }
    });
  }
}