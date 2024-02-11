using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2._2
{
    internal abstract class Animal
    {
        public string Name { get; set; }

        public int numberOfLegs { get; set; }

        void SetName(string name)
        {
            this.Name = name;
        }

        public string GetName()
        {
            return this.Name;
        }

        public int getNumOfLegs()
        {
            return this.numberOfLegs;
        }

        public abstract void displayAnimal();
    }
}
