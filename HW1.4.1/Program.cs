namespace HW1._4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 200;
            while (a >= 200 && a<500 && a%17 == 0) 
            {
                Console.Write($"{a},");
                a += a;
            }
            Console.ReadKey();
        }
    }
}