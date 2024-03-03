using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Entities;

namespace Todo.Domain.Test.EntityTest
{
    [TestClass]
    public class TodoItemTest
    {
        private readonly TodoItem _todo = new TodoItem("Tarefa 1", "usuario", DateTime.Now);
        [TestMethod]
        public void Dado_um_novo_todo_o_mesmo_nao_pode_ser_concluido()
        {

            Assert.AreEqual(_todo.Done, false);
        }
    }
}