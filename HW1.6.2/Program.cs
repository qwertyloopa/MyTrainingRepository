namespace HW1._6._2
{
     internal class Program
    {    
        static void Main(string[] args)
        {
            int[,] matrix1 = new int[2, 2] 
            { 
                { 1, 2 }, 
                { 3, 4 } 
            };
            int[,] matrix2 = new int[2, 2] 
            { 
                { 5, 6 }, 
                { 7, 8 } 
            };

            int[,] res = new int[2, 2];
            Addiction(matrix1, matrix2, res);

            Console.WriteLine(string.Join(", ", res));
        }

        static int[,] Addiction(int[,] a, int[,] b, int[,] c)
        {
            for (int i = 0; i < a.GetLength(0); i++ )
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    c[i,j] = a[i,j] + b[i,j]; 
                }
            }
            return c;
        }
    }
}