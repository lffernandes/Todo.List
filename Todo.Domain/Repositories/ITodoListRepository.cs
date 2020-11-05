using System;
using System.Collections.Generic;
using Todo.Domain.Entities;

namespace Todo.Domain.Repositories
{
    public interface ITodoListRepository
    {
        void Create(TodoList todo);
        void Update(TodoList todo);
        void MarkDisable(TodoList todo);
        void MarkEnable(TodoList todo);
    }
}