using Exo1_TDD.Bibliotheque;
using static System.Formats.Asn1.AsnWriter;

namespace Exo1_TDD.TestsxUnit
{
    public class GradingCalculatorTests
    {
        private readonly GradingCalculator _gradingCalculator;

        public GradingCalculatorTests()
        {
            _gradingCalculator = new GradingCalculator();
        }

        [Theory]
        [InlineData(95, 90, 'A')] 
        [InlineData(85, 90, 'B')] 
        [InlineData(65, 90, 'C')] 
        [InlineData(95, 65, 'B')] 
        [InlineData(95, 55, 'F')]
        [InlineData(65, 55, 'F')]
        [InlineData(50, 90, 'F')]
       
      
        public void GetGrade_VariousScores(int score, int attendance, char expectedGrade)
        {
            // Arrange
            _gradingCalculator.Score = score;
            _gradingCalculator.AttendancePercentage = attendance;

            // Act
            var result = _gradingCalculator.GetGrade();

            // Assert
            Assert.Equal(expectedGrade, result);
        }
    }
}







