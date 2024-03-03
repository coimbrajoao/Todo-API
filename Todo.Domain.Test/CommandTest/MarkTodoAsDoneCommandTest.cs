using System;
using Todo.Domain.Commands;

namespace Todo.Domain.Test.CommandTest
{
    [TestClass]
    public class MarkTodoAsDoneCommandTest
    {
        private readonly MarkTodoAsDoneCommand _invalidCommand = new MarkTodoAsDoneCommand("", Guid.NewGuid());
        private readonly MarkTodoAsDoneCommand _validCommand = new MarkTodoAsDoneCommand("usuario", Guid.NewGuid());

        public MarkTodoAsDoneCommandTest()
        {
            _invalidCommand.Validate();
            _validCommand.Validate();
        }
        [TestMethod]
        public void Dado_comando_invalido_nao_mexer_no_todo()
        {
            Assert.AreEqual(_invalidCommand.Valid, false);
        }

        [TestMethod]
        public void Dado_comando_valido_alterar_status_todo()
        {

            Assert.AreEqual(_validCommand.Valid, true);
        }
    }
}
