using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2._2
{
    internal class Elephant : Animal, IHerbivore
    {
        string Sound;
        string Color;
        public string typeH { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string foodH { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        public Elephant(string sound, string color)
        {
            Color = color;
            Sound = sound;
        }

        public override void displayAnimal()
        {
            Console.WriteLine("I'm an Elephant");
        }

        public void DisplayEatH()
        {
            throw new NotImplementedException();
        }
    }
}
