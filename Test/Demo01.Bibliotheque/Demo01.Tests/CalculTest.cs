
using System.Globalization;

namespace Demo01.Bibliotheque
{
    [TestClass]
    public sealed class CalculTest
    {
        [TestMethod]
        public void WhenDivision_10_30_Then_40()
        {
            var calcul = new Calcul();
            var result = calcul.Addition(10, 30);
            Assert.AreEqual(40, result);
        }
        [TestMethod]
        public void WhenDivision_10_31_Then_3()
        {
            //arrange
            var calcul = new Calcul();
            //Act
            double result = calcul.Division(30, 10);
            //Assert
            Assert.AreEqual(3, result);
        }
        [TestMethod]
         public void WhenDivision_1_0_Then_DivideByZeroException()
        {
            // Arange
            var calcul = new Calcul();
            //Act et Assert
            Assert.ThrowsException
        }
    }
}
