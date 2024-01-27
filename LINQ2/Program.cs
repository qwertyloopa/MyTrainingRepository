namespace LINQ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] A = { "Hello", "here", "we", "are" };
            var B = A.Select(s => s[0]);
            var C = B.Reverse().ToArray();

            foreach (var x in C)
            {
                Console.WriteLine(x);
            }

            Console.ReadKey();
        }
    }
}