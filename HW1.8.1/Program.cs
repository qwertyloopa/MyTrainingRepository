namespace HW1._8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bag bag = new Bag();
            bag.Open();

            Item item1 = new Item("Книга");
            Item item2 = new Item("Ключ");
            Item item3 = new Item("Зелье");

            bag.AddItem(item1);
            bag.AddItem(item2);
            bag.AddItem(item3);

            int indexToRemove = 1;
            Item removedItem = bag.RemoveItem(indexToRemove);

            bag.Close(); // Закрытие сумки

            bag.AddItem(new Item("Карта")); // Не добавится, так как сумка закрыта

            Console.WriteLine($"Удаленный предмет: {removedItem.GetName}");
        }

        public class Item
        {
            private string Name = "unknown";

            public void SetName(string name)
            {
                Name = name;
            }

            public string GetName()
            {
                return Name;
            }
        }

        public class Bag : Item
        {
            private Item[] items;
            private bool isOpen;

            public Bag()
            {
                items = new Item[8];
                isOpen = false;
            }

            public void Open()
            {
                isOpen = true;
                Console.WriteLine("Сумка открыта.");
            }

            public void Close()
            {
                isOpen = false;
                Console.WriteLine("Сумка закрыта.");
            }

            public void AddItem(Item item)
            {
                if (!isOpen)
                {
                    Console.WriteLine("Сумка закрыта. Откройте сумку перед добавлением предметов.");
                    return;
                }

                if (IsBagFull())
                {
                    Console.WriteLine("Сумка полна. Невозможно добавить больше предметов.");
                }
                else
                {
                    for (int i = 0; i < items.Length; i++)
                    {
                        if (items[i] == null)
                        {
                            items[i] = item;
                            Console.WriteLine($"Предмет '{item.GetName}' добавлен в сумку.");
                            break;
                        }
                    }
                }
            }

            public Item RemoveItem(int index)
            {
                if (!isOpen)
                {
                    Console.WriteLine("Сумка закрыта. Откройте сумку перед извлечением предметов.");
                    return null;
                }

                if (index < 0 || index >= items.Length)
                {
                    Console.WriteLine("Неверный индекс. Невозможно удалить предмет.");
                    return null;
                }

                Item removedItem = items[index];
                items[index] = null;

                Console.WriteLine($"Предмет '{removedItem.GetName}' был удален из сумки.");
                return removedItem;
            }

            private bool IsBagFull()
            {
                return Array.TrueForAll(items, item => item != null);
            }
        }
    }
}