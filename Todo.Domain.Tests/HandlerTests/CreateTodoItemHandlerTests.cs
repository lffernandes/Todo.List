using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Commands;
using Todo.Domain.Handlers;
using Todo.Domain.Tests.Repositories;
namespace Todo.Domain.Tests.CommandTests
{

    [TestClass]
    public class CreateTodoItemHandlerTests
    {
        private readonly CreateTodoItemCommand _invalidItemCommand = new CreateTodoItemCommand(Guid.NewGuid(), "", "", DateTime.Now);
        private readonly CreateTodoItemCommand _validItemCommand = new CreateTodoItemCommand(Guid.NewGuid(), "Título da tarefa", "Lzfrnds", DateTime.Now);
        private readonly TodoItemHandler _itemhandler = new TodoItemHandler(new FakeTodoItemRepository());
        private GenericCommandResult _itemresult = new GenericCommandResult();

        [TestMethod]
        public void Dado_um_comando_invalido_deve_interromper_a_execucao()
        {
            _itemresult = (GenericCommandResult)_itemhandler.Handle(_invalidItemCommand);
            Assert.AreEqual(_itemresult.Success, false);
        }
        [TestMethod]
        public void Dado_um_comando_invalido_deve_criar_a_tarefa()
        {
            _itemresult = (GenericCommandResult)_itemhandler.Handle(_validItemCommand);
            Assert.AreEqual(_itemresult.Success, true);
        }
    }
}