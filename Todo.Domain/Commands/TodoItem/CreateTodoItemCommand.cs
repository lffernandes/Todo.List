using System;
using Flunt.Notifications;
using Flunt.Validations;
using Todo.Domain.Commands.Contracts;




namespace Todo.Domain.Commands
{
    public class CreateTodoItemCommand : Notifiable, ICommand
    {
        public CreateTodoItemCommand() { }

        public CreateTodoItemCommand(Guid list, string title, string user, DateTime date)
        {
            Title = title;
            User = user;
            Date = date;
            ListId = list;
        }
        public string Title { get; set; }

        public string User { get; set; }

        public DateTime Date { get; set; }

        public Guid ListId { get; set; }

        public void Validate()
        {
            AddNotifications(
                new Contract()
                 .Requires()
                 .HasMinLen(Title, 3, "Title", "Por favor, descreva melhor esta tarefa")
                 .HasMinLen(User, 6, "User", "Usuário inválido")
            //  .IsEmpty(ListId, "ListId", "Lista inválida.")

            );
        }
    }
}