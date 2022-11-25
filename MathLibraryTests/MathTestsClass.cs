using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathLibraryP;
namespace MathLibraryTests
{
    [TestClass]
    public class MathTestsClass
    {
        /// <summary>
        /// Нахождение суммы
        /// </summary>
        [TestMethod]
        public void Sum_1And1_ReturnSum()
        {
            int x = 1;
            int y = 1;
            int excepted = 2;
            //Act
            int actual =MathClass.Sum(x,y);
            //Assert
            Assert.AreEqual(excepted, actual);
        }
    }
}
