namespace Threads4
{
    internal class Program
    {
        static object sync = new object();

        static void ReadAndWrite(string inputFile, string outputFile)
        {
            string content = File.ReadAllText(inputFile);
            lock (sync)
            {
                File.AppendAllText(outputFile, content);
            }
        }

        static void Main(string[] args)
        {
            File.Create("file1.txt").Close();
            File.Create("file2.txt").Close();
            File.Create("file3.txt").Close();
            File.WriteAllText("file1.txt", "Hello, this is file1.\n");

            Thread t1 = new Thread(() => ReadAndWrite("file1.txt", "file3.txt"));
            Thread t2 = new Thread(() => ReadAndWrite("file2.txt", "file3.txt"));

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            Console.WriteLine(File.ReadAllText("file3.txt"));
        }
    }
}
