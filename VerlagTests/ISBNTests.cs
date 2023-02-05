using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Verlag;

namespace VerlagTests
{
    [TestClass]
    public class ISBNtests
    {
        [TestMethod]
        public void ISBN_DarfGesetztWerden()
        {
            //Arrange
            string ISBN = "9783770436163";

            //ACT
            Buch b = new Buch("autor", "titel");
            b.ISBN = ISBN;

            //Assert
            Assert.AreEqual(b.ISBN, ISBN);
        }
    }
}