namespace HW1._7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mas = { 1, 2, 3 };
            Console.WriteLine(string.Join(", ", mas));
            int[] invertedMas = ArrayWorker.InvertArray(mas);
            Console.WriteLine(string.Join(", ", invertedMas));
        }
    }
}