
using Exo1_TDD.Bibliotheque;


namespace FibTests
{
    [TestClass]

    public class FibTest
    {

        public void GetFib_Range1_IsNotEmpty()
        {
            // Arrange
            Fib fib = new Fib(1);

            // Act
            List<int> result = fib.GetFibSeries();

            // Assert
            Assert.IsNotNull(result);
        }


        [TestMethod]
        public void GetFibSeries_Range1_Returnszero()
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
        public void GetFibSeries_Range6_6Elements()
        {
            // Arrange
            Fib fib = new Fib(6);

            // Act
           var result = fib.GetFibSeries();

            // Assert
            Assert.AreEqual(6, result.Count);
        }

        [TestMethod]
        public void GetFibSeries_Range6_NotContain4()
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
        public void GetFib_IsAscendant()
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

