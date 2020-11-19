using System;
using Todo.Domain.Entities;
using Todo.Domain.Repositories;

namespace Todo.Domain.Tests.Repositories

{
    public class FakeTodoListRepository : ITodoListRepository
    {
        public void Create(TodoList todo)
        {

        }

        public TodoList GetById(Guid id, string user)
        {
            return new TodoList("Titulo Aqui", "lzfrnds", DateTime.Now);
        }

        public void MarkDisable(TodoList todo)
        {

        }

        public void MarkEnable(TodoList todo)
        {

        }

        public void Update(TodoList todo)
        {

        }

    }

}
