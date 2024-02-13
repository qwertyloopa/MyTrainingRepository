using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2._1._2
{
    internal class Coffee
    {
        public Strength Strength { get; set; }
        public int Volume { get; set; }

        public Coffee(Strength strength, int volume)
        {
            Strength = strength;
            Volume = volume;
        }

        public static Coffee operator +(Water water, Coffee befCoffee)
        {
            Coffee coffee = new Coffee(befCoffee.Strength, water.Volume + befCoffee.Volume);

            if (water.Temperature > 90)
            {
                coffee.Strength++;
            }
            else if (water.Temperature < 80)
            {
                coffee.Strength--;
            }

            return coffee;
        }

        public override string ToString()
        {
            return $"{Volume}, {Strength}";
        }
    }
    enum Strength
    {
        Weak, 
        Medium, 
        Strong 
    }
}
