using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async2
{
    internal class ContinueWith
    {
        public static void Start()
        {
            Console.WriteLine("Введите число");
            int time = Int32.Parse(Console.ReadLine());
            Callback(time);
            Console.WriteLine("Квадрат данного числа равен: {0}", time ^ 2);
            Console.ReadLine();
        }
        static void Callback(int time)
        {
            Task taskMain = Task.Run(() => {
                for (int i = 0; i < time; i++)
                {
                    Console.WriteLine($"{i} итерация объекта");
                }
            });
            taskMain.ContinueWith(obj => Console.WriteLine("Hello from callback, again"));
        }
    }
}
