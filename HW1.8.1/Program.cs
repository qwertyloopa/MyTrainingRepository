namespace HW1._8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Item item = new Item();

            item.GetName();
            Console.WriteLine("Введите имя");
            item.SetName(Console.ReadLine());
            item.GetName();
        }

        class Item
        {
            private string Name = "unknown";

            public void SetName(string name)
            {
                Name = name;
            }

            public void GetName()
            {
                Console.WriteLine(Name);
            }
        }
    }
}