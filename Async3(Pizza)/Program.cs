namespace Async3_Pizza_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Открываем смену...");
            Thread.Sleep(3000);
            Pizzeria freddyFazbearsPizza = new Pizzeria(10);
            int[] orders = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int order in orders) freddyFazbearsPizza.CreatePizzaAsync(order);
            Console.ReadKey();
        }
    }
}