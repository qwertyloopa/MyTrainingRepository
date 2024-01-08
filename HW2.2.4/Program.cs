using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2._2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            List<Person> listOfPeople = new List<Person>();
            for (int i = 0; i < 10; i++)
            {
                listOfPeople.Add(new Person(rnd.Next(1, 18), (Gender)rnd.Next(1, 2)));
            }
            listOfPeople.Sort();
            foreach (Person p in listOfPeople)
            {
                Console.WriteLine($"{p.age}, {p.gender}");
            }
        }
    }

}