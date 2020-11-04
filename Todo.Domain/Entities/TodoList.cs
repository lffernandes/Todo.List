using System;
using Todo.Domain.Helpers;


namespace Todo.Domain.Entities
{
    public class TodoList : Entity
    {
        public TodoList(string title, string user, DateTime date)
        {
            Title = title;
            Status = true;
            Date = date;
            User = user;
        }

        public string Title { get; private set; }

        public bool Status { get; private set; }

        public DateTime Date { get; private set; }

        public string User { get; private set; }

        public void MarkAsEnable()
        {
            Status = true;
        }

        public void MarkAsDisable()
        {
            Status = false;
        }

        public void UpdateTitle(string title)
        {
            Title = title;
        }

    }

}
