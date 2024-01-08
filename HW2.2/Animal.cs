using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2._2
{
    internal abstract class Animal
    {
        string Name { get; set; }

        int numOfLegs { get; set; }

        void SetName(string name)
        {
            this.Name = name;
        }

        public string GetName()
        {
            return this.Name;
        }

        public void getNumOfLegs()
        {
            Console.WriteLine(numOfLegs);
        }

        public abstract void displayAnimal();
    }
}
