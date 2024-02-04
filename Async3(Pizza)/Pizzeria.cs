using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async3_Pizza_
{
    internal class Pizzeria
    {
        private SemaphoreSlim semaphore;
        public Pizzeria(int workers)
        {
            semaphore = new SemaphoreSlim(workers, workers);
        }
        public async Task CreatePizzaAsync(int order)
        {
            await semaphore.WaitAsync();
            try
            {
                Console.WriteLine($"Приготовление пиццы для заказа {order} началось.");
                await Task.Delay(10000);
                Console.WriteLine($"Приготовление пиццы для заказа {order} закончилось.");
            }
            finally
            {
                semaphore.Release();
            }
        }
    }
}
