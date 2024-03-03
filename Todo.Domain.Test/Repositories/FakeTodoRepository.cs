using Todo.Domain.Entities;
using Todo.Domain.Repositories;

namespace Todo.Domain.Test.Repositories
{
    public class FakeTodoRepository : ITodoRepository //Fake é um tipo de Mock
    {
        public void Create(TodoItem todo)//mock é um objeto que simula o comportamento de um objeto real em testes
        {
            
        }

        public IEnumerable<TodoItem> GetAll(string user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TodoItem> GetAllByPeriod(string user, DateTime date, bool done)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TodoItem> GetAllDone(string user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TodoItem> GetAllUndone(string user)
        {
            throw new NotImplementedException();
        }


        public TodoItem GetById(Guid id, string user)
        {
            return new TodoItem("Tarefa 1", "usuario", System.DateTime.Now);
        }


        public void Update(TodoItem todo)
        {
          
        }

    }
}