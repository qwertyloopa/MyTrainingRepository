namespace LINQ1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { -10, 22, 13, 43, -5, -12, 100 };
            IEnumerable<int> ints2 = from i in ints
                                     where i > 0
                                     select i;
            var result = ints2.Reverse().ToList();
            
            foreach (int r in result)
            {
                Console.WriteLine(r);
            }

            Console.ReadKey();
        }
    }
}