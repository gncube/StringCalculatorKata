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

        [Theory]
        [InlineData(1, "0,1")]
        [InlineData(3, "0,1,2")]
        [InlineData(83, "0,1,2,3,4,5,6,7,12,43")]
        public void ReturnsSumGivenStringWithCommaDelimeters(int expectedResult, string numbers)
        {
            var stringCalculator = new StringCalculatorProcessor();
            var actual = stringCalculator.Add(numbers);

            Assert.Equal(expectedResult, actual);
        }

        [Theory]
        [InlineData(6, "0,1\n2,3")]
        [InlineData(6, "0\n1\n2\n3")]
        [InlineData(83, "0,1\n2,3\n4,5,6,7,12,43")]
        public void ReturnsSumGivenStringWithCommaOrNewlineDelimeters(int expectedResult, string numbers)
        {
            var stringCalculator = new StringCalculatorProcessor();
            var actual = stringCalculator.Add(numbers);

            Assert.Equal(expectedResult, actual);
        }

        [Theory]
        [InlineData(6, "//;\n1;2;3")]

        public void ReturnsSumGivenStringWithCustomDelimeter(int expectedResult, string numbers)
        {
            var stringCalculator = new StringCalculatorProcessor();
            var actual = stringCalculator.Add(numbers);

            Assert.Equal(expectedResult, actual);
        }
    }
}