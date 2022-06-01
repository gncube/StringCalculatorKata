namespace StringCalculator.Console
{
    public class StringCalculatorProcessor
    {
        public StringCalculatorProcessor()
        {
        }

        public int Add(string numbers)
        {
            if (string.IsNullOrWhiteSpace(numbers))
                return 0;

            var delimeters = new List<char> { ',', '\n' };

            string numberString = numbers;

            if (numberString.StartsWith("//"))
            {
                var splitInput = numberString.Split('\n');

                var newDelimeter = splitInput.First().Trim('/');

                numberString = string.Join('\n', splitInput.Skip(1));

                delimeters.Add(Convert.ToChar(newDelimeter));
            }

            var result = numberString.Split(delimeters.ToArray())
                .Select(n => int.Parse(n))
                .Sum();

            return result;
        }
    }
}