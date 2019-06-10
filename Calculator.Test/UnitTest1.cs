using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_3_and_5_should_equal_8()
        {
            //Arrange
            Calculator calc = new Calculator();

            //Act
            int result = calc.Add(3, 5);

            //Assert
            Assert.AreEqual(8, result);
        }
    }
}
