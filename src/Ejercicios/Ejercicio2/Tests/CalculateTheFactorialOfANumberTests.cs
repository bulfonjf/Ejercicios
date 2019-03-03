using Ejericios.Ejercicio2.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ejercicios.Ejercicio2.Tests
{
    [TestClass]
    public class CalculateTheFactorialOfANumberTests
    {
        [DataTestMethod]
        [DataRow((uint)0,(uint)1)]
        [DataRow((uint)1,(uint)1)]
        [DataRow((uint)2,(uint)2)]
        [DataRow((uint)3,(uint)6)]
        [DataRow((uint)4,(uint)24)]
        public void GivenAValue_ShouldReturnExpected(uint value, uint expected)
        {
            // Arrange

            // Act
            var result = CalculateTheFactorialOfANumberService.Calculate(value);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}