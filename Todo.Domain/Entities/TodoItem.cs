using System;
using Todo.Domain.Helpers;

namespace Todo.Domain.Entities
{
    public class TodoItem : Entity
    {
        public TodoItem(Guid listid, string title, string user, DateTime date)
        {
            Title = title;
            Status = StatusItem.ToDo;
            Date = date;
            User = user;
            ListId = listid;

        }

        public string Title { get; private set; }

        public StatusItem Status { get; private set; }

        public DateTime Date { get; private set; }

        public string User { get; private set; }

        public Guid ListId { get; private set; }

        public void UpdateStatusItem(StatusItem status)
        {
            Status = status;
        }
        public void UpdateTitle(string title)
        {
            Title = title;
        }

    }

}
