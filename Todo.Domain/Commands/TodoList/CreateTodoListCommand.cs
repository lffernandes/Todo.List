using System;
using Flunt.Notifications;
using Flunt.Validations;
using Todo.Domain.Commands.Contracts;




namespace Todo.Domain.Commands
{
    public class CreateTodoListCommand : Notifiable, ICommand
    {
        public CreateTodoListCommand() { }

        public CreateTodoListCommand(string title, string user, DateTime date)
        {
            Title = title;
            User = user;
            Date = date;

        }
        public string Title { get; set; }

        public string User { get; set; }

        public DateTime Date { get; set; }


        public void Validate()
        {
            AddNotifications(
                new Contract()
                 .Requires()
                 .HasMinLen(Title, 3, "Title", "Por favor, descreva melhor sua lista")
                 .HasMinLen(User, 6, "User", "Usuário inválido")

            );
        }
    }
}