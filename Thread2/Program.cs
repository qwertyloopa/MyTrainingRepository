namespace Threads2
{
    internal class Program
    {
        static int count = 0;
        static Mutex mutex = new Mutex();

        static void Action()
        {
            mutex.WaitOne();
            for (int i = 0; i < 10; i++)
            {
                count++;
                Console.WriteLine("Thread {0}: Count = {1}", Thread.CurrentThread.Name, count);
                Thread.Sleep(100);
            }
            mutex.ReleaseMutex();
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Action); t1.Name = "First";
            Thread t2 = new Thread(Action); t2.Name = "Second";

            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();

            Console.WriteLine($"Finally count is {count}");
        }

    }
}
