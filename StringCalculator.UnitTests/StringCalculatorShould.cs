using StringCalculator.Console;

namespace StringCalculator.UnitTests
{
    public class StringCalculatorShould
    {
        [Fact]
        public void ReturnAnInteger()
        {
            var stringCalculator = new StringCalculatorProcessor();

            var result = stringCalculator.Add("numbers");
            var expectedResult = 1;

            Assert.Equal(expectedResult, result);
        }
    }
}