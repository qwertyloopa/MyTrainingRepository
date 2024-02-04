using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Async1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;
            Task task = Task.Run(() => DoWork(token), token);
            Thread.Sleep(5000);
            cts.Cancel();
            Console.WriteLine("Завершение работы метода Main");
            Console.ReadKey();
        }

        static void DoWork(CancellationToken token)
        {
            Console.WriteLine("Начало работы метода DoWork");
            for (int i = 0; i < 7; i++)
            {
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("Отмена работы метода DoWork");
                    return;
                }
                Console.WriteLine("Выполнение итерации {0}", i + 1);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Конец работы метода DoWork");
        }
    }
}
