using System;
using System.Threading;
using System.Threading.Tasks;

namespace Async2
{

    internal class Program
    {
        public static int time;
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            time = Int32.Parse(Console.ReadLine());
            Callback();
            Console.WriteLine("Квадрат данного числа равен: {0}", time^2);
            Console.ReadKey();
        }
        
        static async void Callback()
        {
            Task taskMain = Task.Run(() => { 
                for (int i = 0; i < time; i++) 
                { 
                    Console.WriteLine("Hello from callback");
                }
            });
            
            var awaiter = taskMain.GetAwaiter();
            
            awaiter.IsCompleted(()=>
            {
                Console.WriteLine("");
            });
        }
    }
}