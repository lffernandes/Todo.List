using Flunt.Notifications;
using Todo.Domain.Commands;
using Todo.Domain.Commands.Contracts;
using Todo.Domain.Entities;
using Todo.Domain.Handlers.Contracts;
using Todo.Domain.Repositories;

namespace Todo.Domain.Handlers
{
    public class TodoItemHandler :
        Notifiable,
        IHandler<CreateTodoItemCommand>

    {
        private readonly ITodoItemRepository _repository;

        public TodoItemHandler(ITodoItemRepository repository)
        {
            _repository = repository;
        }
        public ICommandResult Handle(CreateTodoItemCommand command)
        {
            // Fail fast Validation
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(false, "Ops, parece que sua tarefa está errada!", command.Notifications);

            var todo = new TodoItem(command.ListId, command.Title, command.User, command.Date);

            _repository.Create(todo);

            return new GenericCommandResult(true, "Tarefa salva", todo);

        }


    }
}
