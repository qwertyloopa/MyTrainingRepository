namespace LINQ5
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = new List<string>{"Hello", "My", "World"};
           

            Console.WriteLine(strings.Median());
        }

        static string Median(this List<string> s)
        {
            string result = s.ElementAt((System.Index)Math.Round((decimal)s.Count()/2));
            return result;
        }
    }
}