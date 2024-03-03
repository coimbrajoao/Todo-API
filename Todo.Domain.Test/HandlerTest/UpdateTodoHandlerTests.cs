using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Domain.Commands;
using Todo.Domain.Handlers;
using Todo.Domain.Test.Repositories;

namespace Todo.Domain.Test.HandlerTest
{
    [TestClass]
    public class UpdateTodoHandlerTests
    {
        private readonly FakeTodoRepository _repository = new FakeTodoRepository();
        private readonly UpdateTodoCommand _invalidCommand = new UpdateTodoCommand();
        private readonly UpdateTodoCommand _validCommand = new UpdateTodoCommand();
        private readonly TodoHandler _handler = new TodoHandler(new FakeTodoRepository());
        private GenericCommandResult _result = new GenericCommandResult();

        public UpdateTodoHandlerTests()
        {
            var todo = _repository.GetById(Guid.NewGuid(), "usuario");
            _invalidCommand = new UpdateTodoCommand( todo.Id,"", "usuario");
            _validCommand = new UpdateTodoCommand(todo.Id, "Titulo da tarefa", "usuario");

        }
        [TestMethod]
        public void UpdateTodo_invalido_nao_alter_tarefa()
        {
            _result = (GenericCommandResult)_handler.Handle(_invalidCommand);
            Assert.AreEqual(_result.Success, false);
        }

        [TestMethod]
        public void UpdateTodo_valido_alter_tarefa()
        {
          _result = (GenericCommandResult)_handler.Handle(_validCommand);
            Assert.AreEqual(_result.Success, true);
        }
    }
}
