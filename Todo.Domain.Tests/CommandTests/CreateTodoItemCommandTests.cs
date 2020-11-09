using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Commands;

namespace Todo.Domain.Tests.CommandTests
{
    [TestClass]
    public class CreateTodoItemCommandTests
    {
        private readonly CreateTodoItemCommand _invalidItemCommand = new CreateTodoItemCommand(Guid.NewGuid(), "", "", DateTime.Now);

        private readonly CreateTodoItemCommand _ValidItemCommand = new CreateTodoItemCommand(Guid.NewGuid(), "Título da tarefa", "Lzfrnds", DateTime.Now);

        public CreateTodoItemCommandTests()
        {
            _invalidItemCommand.Validate();
            _ValidItemCommand.Validate();
        }


        [TestMethod]
        public void Dado_um_comando_invalido()
        {
            Assert.AreEqual(_invalidItemCommand.Valid, false);
        }

        [TestMethod]
        public void Dado_um_comando_valido()
        {
            Assert.AreEqual(_ValidItemCommand.Valid, true);
        }

    }
}
