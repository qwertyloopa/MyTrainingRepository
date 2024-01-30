namespace Threads3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            var squares = new List<int>();

            Parallel.ForEach(nums, x =>
            {
                var square = x ^ 2;
                squares.Add(square);
                Console.WriteLine($"Квадрат числа {x} равен {square}");
            });
        }
    }
}
