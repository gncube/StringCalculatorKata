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

        [Theory]
        [InlineData("Negatives not allowed: -1", "-1,2")]
        [InlineData("Negatives not allowed: -1,-2", "-1,-2")]
        public void ThrowsGivenNegativeInput(string expectedResult, string numbers)
        {
            var stringCalculator = new StringCalculatorProcessor();
            Action action = () => stringCalculator.Add(numbers);

            var ex = Assert.Throws<Exception>(action);

            Assert.Equal(expectedResult, ex.Message);
        }

        [Theory]
        [InlineData("1,2,3000", 3)]
        [InlineData("1001,2", 2)]
        [InlineData("1000,2", 1002)]
        public void ReturnsSumGivenStringIgnoringValuesOver1000(string numbers, int expectedResult)
        {
            var stringCalculator = new StringCalculatorProcessor();
            var actual = stringCalculator.Add(numbers);

            Assert.Equal(expectedResult, actual);
        }
    }
}