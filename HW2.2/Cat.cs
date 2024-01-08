using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2._2
{
    internal class Cat : Animal, ICarnivore
    {
        string Sound = "Meow";
        string Color { set => Console.ReadLine(); }
        string ICarnivore.typeC { get; set; }
        string ICarnivore.foodC { get; set; }


        public Cat(string sound, string color)
        {
            Sound = sound;
            Color = color;
        }

        public override void displayAnimal()
        {
            Console.WriteLine("I'm a cat");
        }

        public void DisplayEatC()
        {
            Console.WriteLine();
        }

    }
}
