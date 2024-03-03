using Flunt.Notifications;
using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Commands
{
    public class MarkTodoAsDoneCommand : Notifiable, ICommand
    {
        public MarkTodoAsDoneCommand() { }

        public MarkTodoAsDoneCommand(string user, Guid id)
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