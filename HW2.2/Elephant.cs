using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2._2
{
    internal class Elephant : Animal, IHerbivore
    {
        string typeH = "Carnivore";
        string Sound = "Meow";
        string colour { get; set; }
        string IHerbivore.typeH { get; set; }
        string IHerbivore.foodH { get; set; }

        public Elephant(string name, int numOfLegs, string sound, string color, string type)
        {
            Name = name;
            numberOfLegs = numOfLegs;
            Sound = sound;
            colour = color;
            type = typeH;
        }

        public override void displayAnimal()
        {
            Console.WriteLine("I'm an Elephant, ");
        }

        public void DisplayEatH()
        {
            Console.WriteLine();
        }
    }
}
