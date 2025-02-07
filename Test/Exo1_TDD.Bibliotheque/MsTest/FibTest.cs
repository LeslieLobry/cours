using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exo1_TDD.Bibliotheque;

namespace FibTests
{
    [TestClass]
    public class FibUnitTest
    {
        [TestMethod]
        public void GetFibSeries_Range1_IsNotEmpty()
        {
            // Arrange
            Fib fib = new Fib(1);

            // Act
            List<int> result = fib.GetFibSeries();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count > 0);
        }

        [TestMethod]
        public void GetFibSeries_Range1_ReturnsListWithZero()
        {
            // Arrange
            Fib fib = new Fib(1);

            // Act
            List<int> result = fib.GetFibSeries();

            // Assert
            CollectionAssert.AreEqual(new List<int> { 0 }, result);
        }

        [TestMethod]
        public void GetFibSeries_Range6_Contains3()
        {
            // Arrange
            Fib fib = new Fib(6);

            // Act
            List<int> result = fib.GetFibSeries();

            // Assert
            Assert.IsTrue(result.Contains(3));
        }

        [TestMethod]
        public void GetFibSeries_Range6_Has6Elements()
        {
            // Arrange
            Fib fib = new Fib(6);

            // Act
            List<int> result = fib.GetFibSeries();

            // Assert
            Assert.AreEqual(6, result.Count);
        }

        [TestMethod]
        public void GetFibSeries_Range6_DoesNotContain4()
        {
            // Arrange
            Fib fib = new Fib(6);

            // Act
            List<int> result = fib.GetFibSeries();

            // Assert
            Assert.IsFalse(result.Contains(4));
        }

        [TestMethod]
        public void GetFibSeries_Range6_ReturnsExpectedList()
        {
            // Arrange
            Fib fib = new Fib(6);
            List<int> expected = new List<int> { 0, 1, 1, 2, 3, 5 };

            // Act
            List<int> result = fib.GetFibSeries();

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetFibSeries_Range6_IsSortedAscending()
        {
            // Arrange
            Fib fib = new Fib(6);

            // Act
            List<int> result = fib.GetFibSeries();

            // Assert
            Assert.IsTrue(result.SequenceEqual(result.OrderBy(x => x)));
        }
    }
}
