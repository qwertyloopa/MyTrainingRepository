using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1._9._1
{
    internal class Animal
    {
        public virtual void Live()
        {
            Console.WriteLine("I'm alive! ");
        }
    }

    internal class HerbivoreAnimal : Animal 
    {
        public override void Live() 
        {
            base.Live();
            Console.WriteLine("I'm Herbivore! ");
        }

        void EatGrass()
        {
            Console.WriteLine("");
        }
    }

    internal class CarnivoreAnimal : Animal
    {
        public override void Live()
        {
            base.Live();
            Console.WriteLine("I'm Carnivore! ");
        }

        void EatMeat()
        {
            Console.WriteLine("Mmmmm, beef!1");
        }
    }
}
