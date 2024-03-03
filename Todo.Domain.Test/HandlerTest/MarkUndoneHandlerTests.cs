using NuGet.Frameworks;
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
    public class MarkUndoneHandlerTests
    {
        private readonly FakeTodoRepository _repository = new FakeTodoRepository();
        private readonly MarkTodoAsUndoneCommand _invalidCommand;
        private readonly MarkTodoAsUndoneCommand _validCommand;
        private readonly TodoHandler _handler = new TodoHandler(new FakeTodoRepository());
        private GenericCommandResult _result = new GenericCommandResult();


        public MarkUndoneHandlerTests()
        {
            var todo = _repository.GetById(Guid.NewGuid(), "usuario");

            _invalidCommand = new MarkTodoAsUndoneCommand("",todo.Id);
            _validCommand = new MarkTodoAsUndoneCommand("usuario",todo.Id);
        }

        [TestMethod]
        public void Dado_um_comando_invalido_deve_interromper_a_execucao()
        {
            _result = (GenericCommandResult)_handler.Handle(_invalidCommand);
            Assert.AreEqual(_result.Success, false);
        }
        [TestMethod]
        public void Dado_um_comando_valido_deve_marcar_a_tarefa_como_nao_concluida()
        {
            _result = (GenericCommandResult)_handler.Handle(_validCommand);
            Assert.AreEqual(_result.Success, true);
        }
    }
}
