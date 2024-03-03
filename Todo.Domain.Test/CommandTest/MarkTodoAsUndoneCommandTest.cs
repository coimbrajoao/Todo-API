using Todo.Domain.Commands;

namespace Todo.Domain.Test.CommandTest
{
    [TestClass]
    public class MarkTodoAsUndoneCommandTest
    {
        private readonly MarkTodoAsUndoneCommand _invalidCommand = new MarkTodoAsUndoneCommand("", Guid.NewGuid());
        private readonly MarkTodoAsUndoneCommand _validCommand = new MarkTodoAsUndoneCommand("usuario", Guid.NewGuid());

        public MarkTodoAsUndoneCommandTest()
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