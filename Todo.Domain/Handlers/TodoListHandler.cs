using Flunt.Notifications;
using Todo.Domain.Commands;
using Todo.Domain.Commands.Contracts;
using Todo.Domain.Entities;
using Todo.Domain.Handlers.Contracts;
using Todo.Domain.Repositories;

namespace Todo.Domain.Handlers
{
    public class TodoListHandler :
        Notifiable,
        IHandler<CreateTodoListCommand>

    {
        private readonly ITodoListRepository _repository;

        public TodoListHandler(ITodoListRepository repository)
        {
            _repository = repository;
        }
        public ICommandResult Handle(CreateTodoListCommand command)
        {
            // Fail fast Validation
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(false, "Ops, parece que sua Lista está errada!", command.Notifications);

            var todo = new TodoList(command.Title, command.User, command.Date);

            _repository.Create(todo);

            return new GenericCommandResult(true, "Lista criada", todo);

        }
    }
}
