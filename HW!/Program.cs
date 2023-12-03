namespace HW__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Random rand = new Random();
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next();
                Console.WriteLine(arr[i].ToString());
            }
            Console.ReadKey();
        }
    }
}