namespace Files2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                Directory.CreateDirectory($"../MyTestFolder{i}");
            }
            Thread.Sleep(3000);
            for (int i = 0;i < 20; i++)
            {
                Directory.Delete($"../MyTestFolder{i}");
            }
        }
    }
}
