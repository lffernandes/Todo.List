using System;
using Flunt.Notifications;
using Flunt.Validations;
using Todo.Domain.Commands.Contracts;
using Todo.Domain.Helpers;

namespace Todo.Domain.Commands
{
    public class MarkTodoListAsEnableCommand : Notifiable, ICommand
    {
        public MarkTodoListAsEnableCommand() { }

        public MarkTodoListAsEnableCommand(Guid id, string user)
        {
            Id = id;
            User = user;

        }

        public Guid Id { get; set; }

        public string User { get; set; }

        public StatusItem Status { get; set; }

        public void Validate()
        {
            AddNotifications(
                new Contract()
                .Requires()
                .HasMinLen(User, 6, "User", "Usuário inválido!")
            );
        }
    }
}