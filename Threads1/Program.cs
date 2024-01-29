using System.Threading;

namespace Threads1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(Numbers);
            Thread thread2 = new Thread(Letters);

            void Numbers(){
                Console.WriteLine("Первый поток запущен");
                for (int i = 0; i < 10;)
                {
                    Thread.Sleep(20);
                    i++;
                    Console.Write(i + " ");
                }
                Console.Write("1 поток завершён ");
            }

            void Letters(){
                Console.WriteLine("Второй поток запущен");
                char[] letters = {'a', 'b', 'c', 'd', 'e', 'f', 'j'};
                foreach(char c in letters){
                    Thread.Sleep(20);
                    Console.Write(c + " ");
                }
                Console.Write("2 поток завершён ");
            }

            thread1.Start();
            thread2.Start();
        }
    }
}
