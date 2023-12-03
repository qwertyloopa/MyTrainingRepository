namespace HW1._5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            bool isParsed = Int32.TryParse(Console.ReadLine(), out int index);
            if (isParsed)
            {
               int result = 1;
               int multiplier = 1;
               while (result / 10 != index)
               {
                    result = index * multiplier;
                    Console.WriteLine($"{index}x{multiplier}={result}");
                    multiplier += 1;
               }
            }
            else
            {
                Console.WriteLine("Попробуйте ввести число");
            }

            Console.ReadKey();
        }
    }
}