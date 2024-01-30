using Newtonsoft.Json;

namespace Files4_JSON_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyItem myItem = new MyItem("Tom", 23);

            string json = JsonConvert.SerializeObject(myItem);
            Console.WriteLine(json);
        }
    }
}
