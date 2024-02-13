using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HW2._1._2.Coffee;

namespace HW2._1._2
{
    internal class GroundBeans
    {
        public Strength Strength { get; set; }
        public int Volume { get; set; }

        public GroundBeans(Strength strength, int volume)
        {
            Strength = strength;
            Volume = volume;
        }

        public Coffee MakeACoffee(Strength str, int volume)
        {
            Coffee coffee = new Coffee(str, volume);
            return coffee;
        }
    }
}
