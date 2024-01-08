namespace HW1._8._3
{
    static class Program
    {
        static void Main(string[] args)
        {
            Random rn = new Random();
            int[] ints = new int[10];
            int maxInt;

            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = rn.Next();
                Console.WriteLine(ints[i]);
            }

            maxInt = FindMax(ints);
            Console.WriteLine($"Максимальное число : {maxInt}");
        }

        public static int FindMax(this int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }
    }

}