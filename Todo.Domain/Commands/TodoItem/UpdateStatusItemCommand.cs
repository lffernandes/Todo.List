using System;
using Flunt.Notifications;
using Flunt.Validations;
using Todo.Domain.Commands.Contracts;
using Todo.Domain.Helpers;

namespace Todo.Domain.Commands
{
    public class UpdateStatusItemCommand : Notifiable, ICommand
    {
        public UpdateStatusItemCommand() { }

        public UpdateStatusItemCommand(Guid id, string user)
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