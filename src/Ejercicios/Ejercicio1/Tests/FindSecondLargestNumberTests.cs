using Ejercicios.Ejercicio1.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ejercicios.Ejercicio1.Tests
{
    [TestClass]
    public class FindSecondLargestNumberTests
    {
        
        [DataTestMethod]
        [DataRow(new int[]{ 1,2,10 }, 2)]
        [DataRow(new int[]{ 1,2,10,20,-30,-40 }, 10)]
        [DataRow(new int[]{ 1,2,10,20,30,40 }, 30)]
        public void GivenAnArray_ShouldReturnExpected(int[] array, int expected)
        {
            // Arrange

            // Act
            var result = FindSecondLargestNumberService.Find(array);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(null)]
        [DataRow(new int[]{})]
        [DataRow(new int[]{ 1 })]
        public void GivenAnInvalidArray_ShouldReturnNull(int[] array)
        {
            // Arrange
            
            // Act
            var result = FindSecondLargestNumberService.Find(array);

            // Assert
            Assert.IsNull(result);
        }
    }
}
