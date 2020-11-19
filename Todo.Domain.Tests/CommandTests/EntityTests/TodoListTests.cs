using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Entities;

namespace Todo.Domain.Tests.EntityTests
{
    [TestClass]

    public class TodoListTests
    {
        private readonly TodoList _validList = new TodoList("Titulo Aqui", "Lzfrnds", DateTime.Now);

        [TestMethod]
        public void Dado_uma_nova_lista_a_mesma_nao_pode_ser_invisivel()
        {
            Assert.AreEqual(_validList.Status, true);
        }
    }
}