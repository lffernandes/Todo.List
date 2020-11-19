using System;
using Todo.Domain.Entities;
using Todo.Domain.Repositories;

namespace Todo.Domain.Tests.Repositories

{
    public class FakeTodoItemRepository : ITodoItemRepository
    {
        public void Create(TodoItem todo)
        {

        }

        public TodoItem GetById(Guid id, string user)
        {
            return new TodoItem(Guid.NewGuid(), "Titulo aqui", "lzfrnds", DateTime.Now);
        }

        public void Update(TodoItem todo)
        {

        }

        public void UpdateStatus(TodoItem todo)
        {

        }
    }
}


