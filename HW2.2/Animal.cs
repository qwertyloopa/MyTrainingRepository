using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2._2
{
    internal abstract class Animal
    {
        
    public string Name { get; private set; }

    public int NumOfLegs { get; private set; }


    public Animal(string name, int numOfLegs)
    {
        Name = name;
        NumOfLegs = numOfLegs;
    }

    public abstract void DisplayAnimal();
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
            return NumOfLegs;
        }

    }
}
