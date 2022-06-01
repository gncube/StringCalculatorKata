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

            var numberList = numberString.Split(delimeters.ToArray())
                .Select(n => int.Parse(n));

            var negatives = numberList.Where(n => n < 0);

            if (negatives.Any())
            {
                string negativeString = string.Join(',', negatives
                    .Select(n => n.ToString()));
                throw new Exception($"Negatives not allowed: {negativeString}");
            }

            var result = numberList
                .Where(n => n <= 1000)
                .Sum();

            return result;
        }
    }
}