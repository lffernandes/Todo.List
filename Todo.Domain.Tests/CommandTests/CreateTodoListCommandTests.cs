using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Commands;

namespace Todo.Domain.Tests.CommandTests
{
    [TestClass]
    public class CreateTodoListCommandTests
    {
        private readonly CreateTodoListCommand _invalidListCommand = new CreateTodoListCommand("", "", DateTime.Now);

        private readonly CreateTodoListCommand _ValidListCommand = new CreateTodoListCommand("Título da Lista", "Lzfrnds", DateTime.Now);

        public CreateTodoListCommandTests()
        {
            _invalidListCommand.Validate();
            _ValidListCommand.Validate();
        }


        [TestMethod]
        public void Dado_um_comando_invalido()
        {
            Assert.AreEqual(_invalidListCommand.Valid, false);
        }

        [TestMethod]
        public void Dado_um_comando_valido()
        {
            Assert.AreEqual(_ValidListCommand.Valid, true);
        }

    }
}
