using StringCalculator.Console;

namespace StringCalculator.UnitTests
{
    public class StringCalculatorShould
    {

        [Theory]
        [InlineData(0, "")]
        [InlineData(0, "0")]
        [InlineData(1, "0,1")]
        [InlineData(3, "0,1,2")]
        [InlineData(83, "0,1,2,3,4,5,6,7,12,43")]
        public void ReturnTheCorrectInteger(int expectedResult, string numbers)
        {
            var stringCalculator = new StringCalculatorProcessor();
            var actual = stringCalculator.Add(numbers);

            Assert.Equal(expectedResult, actual);
        }
    }
}