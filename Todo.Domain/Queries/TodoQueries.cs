using System.Linq.Expressions;
using Todo.Domain.Entities;

namespace Todo.Domain.Queries
{
    public static class TodoQueries
    {
        public static Expression<Func<TodoItem, bool>> GetAll(string user)
        {
            return x => x.User == user;
        }

        public static Expression<Func<TodoItem, bool>> GetAllByPeriod(string user, DateTime date, bool done)
        {
            return x => x.User == user && x.Done == done && x.Date.Date == date.Date;
        }

        public static Expression<Func<TodoItem, bool>> GetAllDone(string user)
        {
            return x => x.User == user && x.Done;
        }

        public static Expression<Func<TodoItem, bool>> GetAllUndone(string user)
        {
            return x => x.User == user && !x.Done;
        }

        public static Expression<Func<TodoItem, bool>> GetById(string user, Guid id)
        {
            return x => x.User == user && x.Id == id;
        }
    }
}