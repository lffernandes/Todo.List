using System;
using System.Collections.Generic;
using Todo.Domain.Entities;

namespace Todo.Domain.Repositories
{
    public interface ITodoItemRepository
    {
        void Create(TodoItem todo);
        void Update(TodoItem todo);
        void UpdateStatus(TodoItem todo);
        TodoItem GetById(Guid id, string user);
    }
}