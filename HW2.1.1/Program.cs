namespace HW2._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Panda josh = new Panda("josh");
            Panda fransis = new Panda("fransis");
            Console.WriteLine(josh.ToString);
            Console.WriteLine(fransis.ToString);

            var result = josh - fransis;
            Console.WriteLine(result.ToString);
        }
    }
}