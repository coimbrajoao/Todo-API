using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Commands;
using Todo.Domain.Entities;
using Todo.Domain.Test.Repositories;

namespace Todo.Domain.Test.CommandTest
{
    [TestClass]
    public class UpdateTodoCommandTests
    {
        private readonly FakeTodoRepository _repository = new FakeTodoRepository();
        private readonly UpdateTodoCommand _invalidCommand;
        private readonly UpdateTodoCommand _validCommand;

        public UpdateTodoCommandTests()
        {
            var todo = _repository.GetById(Guid.NewGuid(), "usuario");

            _invalidCommand = new UpdateTodoCommand(todo.Id, "Teste", "");
            _validCommand = new UpdateTodoCommand(todo.Id, "Título da Tarefa", "andrebaltieri");
        }

        [TestMethod]
        public void Dado_um_comando_invalido_nao_alterar_informacao()
        {
            _invalidCommand.Validate();
            Assert.IsFalse(_invalidCommand.Valid);
        }

        [TestMethod]
        public void Dado_um_comando_Valido_alterar_informacao()
        {
            _validCommand.Validate();
            Assert.IsTrue(_validCommand.Valid);
        }
    }
}
