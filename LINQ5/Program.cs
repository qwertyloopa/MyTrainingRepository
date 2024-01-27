namespace LINQ5
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = new List<string>{"Hello", "My", "Little", "World"};
           

            Console.WriteLine(strings.Median());
        }

        static string Median(this List<string> s)
        {
           return s.ElementAt(s.Count()/2);
        }
    }
}