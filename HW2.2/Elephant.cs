using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2._2
{
    internal class Elephant : Animal, IHerbivore
    {
        public string Sound { get; set; }
        public string Colour { get; set; }
        public string Type { get; set; }
        public string Food { get; set; }

        public Elephant(string name, int numOfLegs, string sound, string colour, string type, string food) : base(name, numOfLegs)
        {
            Sound = sound;
            Colour = colour;
            Type = type;
            Food = food;
        }

        public override void DisplayAnimal()
        {
            Console.WriteLine($"Name: {Name}, NumOfLegs: {NumOfLegs}, Sound: {Sound}, Colour: {Colour}, Type: {Type}, Food: {Food}");
        }

        public void DisplayEat()
        {
            Console.WriteLine($"{Name} eats {Food}");
        }
    }
}
