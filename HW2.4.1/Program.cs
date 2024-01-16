namespace HW2._4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store walmart = new Store("Марина");
            walmart.Add(new Product("Coca-Cola", 1.5f));
            //walmart.Add(new Product("Coca-Cola", 1.5f));
            walmart.Add(new Product("Pepsi", 1.25f));

            //walmart.Sell("Coca-Cola", 1.4f);
            walmart.Sell("Pepsi", 1.25f);
        }
    }
}