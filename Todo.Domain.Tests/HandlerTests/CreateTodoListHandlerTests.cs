using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Commands;
using Todo.Domain.Handlers;
using Todo.Domain.Tests.Repositories;

namespace Todo.Domain.Tests.CommandTests
{

    [TestClass]
    public class CreateTodoListHandlerTests
    {
        private readonly CreateTodoListCommand _invalidListCommand = new CreateTodoListCommand("", "", DateTime.Now);
        private readonly CreateTodoListCommand _validListCommand = new CreateTodoListCommand("Título da Lista", "Lzfrnds", DateTime.Now);
        private readonly TodoListHandler _listhandler = new TodoListHandler(new FakeTodoListRepository());
        private GenericCommandResult _listresult = new GenericCommandResult();

        [TestMethod]
        public void Dado_um_comando_invalido_deve_interromper_a_execucao()
        {
            _listresult = (GenericCommandResult)_listhandler.Handle(_invalidListCommand);
            Assert.AreEqual(_listresult.Success, false);
        }
        [TestMethod]
        public void Dado_um_comando_invalido_deve_criar_a_tarefa()
        {
            _listresult = (GenericCommandResult)_listhandler.Handle(_validListCommand);
            Assert.AreEqual(_listresult.Success, true);
        }
    }
}