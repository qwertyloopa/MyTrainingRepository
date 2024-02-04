using System;
using System.Threading;
using System.Threading.Tasks;


namespace Async2
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int time = Int32.Parse(Console.ReadLine());
            Callback(time);
            Console.WriteLine("Квадрат данного числа равен: {0}", time^2);
            Console.ReadKey();
        }
        
        static void Callback(int time)
        {
            Task taskMain = Task.Run(() => { 
                for (int i = 0; i < time; i++) 
                { 
                    Console.WriteLine($"{i} итерация объекта");
                }
            });
            
            var awaiter = taskMain.GetAwaiter();
            awaiter.OnCompleted(()=>{
                Console.WriteLine("Hello from callback");
                Console.WriteLine("Переходим к ContinueWith");
                ContinueWith.Start();
        });
        }
    }
}