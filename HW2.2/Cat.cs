using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2._2
{
    internal class Cat : Animal, ICarnivore
    {
        string typeC = "Carnivore";
        string Sound = "Meow";
        string colour { get; set; }
        string ICarnivore.typeC { get; set; }
        string ICarnivore.foodC { get; set; }


        public Cat(string name, int numOfLegs, string sound, string color, string type)
        {
            Name = name;
            numberOfLegs = numOfLegs;
            Sound = sound;
            colour = color;
            type = typeC;
        }

        public override void displayAnimal()
        {
            Console.WriteLine($"Name: {Name}, NumOfLegs: {numberOfLegs}, Sound: {Sound}, Colour: {colour}, Type: {typeC}");
        }

        public void DisplayEatC()
        {
            Console.WriteLine($"{Name} eats meat");
        }

    }
}
