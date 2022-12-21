using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyTaskAPI.Models;

namespace MyTaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetTodos()
        {
            var MyTodos = AllTodos();
            return Ok(MyTodos);
        }

        //Get todos
        private List<Todo> AllTodos()
        {
            var todos = new List<Todo>();

            var todo1 = new Todo
            {
                Id = 1,
                Title = "Get vegies",
                Description = "Get Vegies for the week",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(2),
                Status = TodoStatus.New
                
            };
            todos.Add(todo1);
            var todo2 = new Todo
            {
                Id = 2,
                Title = "Get books",
                Description = "Get books for school",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(2),
                Status = TodoStatus.Completed

            };
            todos.Add(todo2);
            return todos;
        }
    }
}
