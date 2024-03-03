using Flunt.Notifications;
using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Commands
{
    public class MarkTodoAsUndoneCommand : Notifiable, ICommand
    {
        public MarkTodoAsUndoneCommand() { }

        public MarkTodoAsUndoneCommand(string user, Guid id)
        {
            User = user;
            Id = id;
        }
        public Guid Id { get; set; }
        public string User {get; set;}
        public void Validate()
        {
            if (string.IsNullOrEmpty(User))
                AddNotification("User", "Usuário inválido");
        }

    }
}