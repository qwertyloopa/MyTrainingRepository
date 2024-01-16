using System.Text;

namespace HW2._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           SuperCollection<ComparableListData> superCollection = new SuperCollection<ComparableListData>();
            superCollection.Add(new ComparableListData(3, "привет"));
            superCollection.Add(new ComparableListData(2, "мир"));
            superCollection.Add(new ComparableListData(4, "кек"));
            superCollection.Add(new ComparableListData(1, "ура"));

            foreach (ComparableListData data in superCollection)
            {
                Console.WriteLine($"{data.IdNumber} , {data.Name}");
            }
        }
    }
}