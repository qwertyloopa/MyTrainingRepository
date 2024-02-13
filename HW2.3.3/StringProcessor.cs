namespace HW2._3._3
{

    public class StringProcessor
    {
        public void ProcessString(string input)
        {
            
            if (string.IsNullOrEmpty(input))
            {
                throw new EmptyStringException("Input string cannot be empty");
            }
            else
            {
                Console.WriteLine($"Processing {input}");
            }
        }
    }
}