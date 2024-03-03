using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Todo.Domain.Commands;
using Todo.Domain.Entities;
using Todo.Domain.Handlers;
using Todo.Domain.Repositories;

namespace Todo.Domain.Api.Controllers
{
    [ApiController]
    [Route("v1/todos")]
    [Authorize]
    public class TodoController : ControllerBase
    {


        [HttpGet]
        [Route("undone")]
        public IEnumerable<TodoItem> GetAllUndone(
            [FromServices] ITodoRepository repository
        )
        {
            var user = User.Claims.FirstOrDefault(x => x.Type == "user_id")?.Value;
            return repository.GetAllUndone("");
        }

        [HttpGet]
        [Route("done")]
        public IEnumerable<TodoItem> GetAllDone(
            [FromServices] ITodoRepository repository
        )
        {
            var user = User.Claims.FirstOrDefault(x => x.Type == "user_id")?.Value;
            return repository.GetAllDone("user");
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<TodoItem> GetAll(
            [FromServices] ITodoRepository repository
        )
        {
            var user = User.Claims.FirstOrDefault(x => x.Type == "user_id")?.Value;
            return repository.GetAll("user");
        }

        [HttpGet]
        [Route("done/today")]
        public IEnumerable<TodoItem> GetAllDoneForToday(
            [FromServices] ITodoRepository repository
        )
        {
            var user = User.Claims.FirstOrDefault(x => x.Type == "user_id")?.Value;
            return repository.GetAllByPeriod("user", DateTime.Now, true);
        }

        [HttpGet]
        [Route("undone/today")]
        public IEnumerable<TodoItem> GetAllUndoneForToday(
            [FromServices] ITodoRepository repository
        )
        {
            var user = User.Claims.FirstOrDefault(x => x.Type == "user_id")?.Value;
            return repository.GetAllByPeriod("user", DateTime.Now, false);
        }

        [HttpGet]
        [Route("done/tomorrow")]
        public IEnumerable<TodoItem> GetAllDoneForTomorrow(
            [FromServices] ITodoRepository repository
        )
        {
            var user = User.Claims.FirstOrDefault(x => x.Type == "user_id")?.Value;
            return repository.GetAllByPeriod("user", DateTime.Now.AddDays(1), true);
        }

        [HttpPost]
        [Route("")]
        public GenericCommandResult Create(
            [FromBody] CreateTodoCommand command,
            [FromServices] TodoHandler handler
        )
        {

            command.User = User.Claims.FirstOrDefault(x => x.Type == "user_id")?.Value;
            return (GenericCommandResult)handler.Handle(command);
        }

        [HttpPut]
        [Route("")]
        public GenericCommandResult Update(
            [FromBody] UpdateTodoCommand command,
            [FromServices] TodoHandler handler
        )
        {
            command.User = User.Claims.FirstOrDefault(x => x.Type == "user_id")?.Value;

            return (GenericCommandResult)handler.Handle(command);
        }

        [HttpPut]
        [Route("mark-as-done")]
        public GenericCommandResult MarkAsDone(
            [FromBody] MarkTodoAsDoneCommand command,
            [FromServices] TodoHandler handler
        )
        {
            command.User = User.Claims.FirstOrDefault(x => x.Type == "user_id")?.Value;

            return (GenericCommandResult)handler.Handle(command);
        }

        [HttpPut]
        [Route("mark-as-undone")]
        public GenericCommandResult MarkAsUndone(
            [FromBody] MarkTodoAsUndoneCommand command,
            [FromServices] TodoHandler handler
        )
        {
            command.User = User.Claims.FirstOrDefault(x => x.Type == "user_id")?.Value;

            return (GenericCommandResult)handler.Handle(command);
        }
    }
}