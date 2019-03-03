using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicios.Ejercicio3.Services;

namespace Ejercicios.Ejercicio3.Tests
{
    [TestClass]
    public class GetItemByKeyTests
    {
        [TestMethod]
        public void GivenAnExistantKey_ShouldPrintTheItem()
        {
            // Arrange
            string existantKey = "exitantKey";
            string expected = "existantObject";
            Dictionary<string, object> dictionary = new Dictionary<string, object>()
            {
                {existantKey, expected},
            };
            
            // Act
           var result = GetItemByKeyService.PerformantPrintObjectTesteable(dictionary, existantKey);

            // Assert
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void GivenAnNonExistantKey_ShouldPrintTheItem()
        {
            // Arrange
            string nonExistanKey = "non existan key";
            string expected = "null";
            Dictionary<string, object> dictionary = new Dictionary<string, object>()
            {
                {"key", "value"},
            };
            
            // Act
           var result = GetItemByKeyService.PerformantPrintObjectTesteable(dictionary, nonExistanKey);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}