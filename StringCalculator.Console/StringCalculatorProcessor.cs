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

            List<string> ints = numbers.Split(',').ToList<string>();

            var sum = 0;

            foreach (var i in ints)
            {
                sum = sum + Convert.ToInt32(i);
            }
            return sum;
        }
    }
}