using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1._7._2
{
    public class Cone
    {
        private double Radius { get; }
        private double Height { get; }

        public Cone(double radius, double height)
        {
            Radius = radius;
            Height = height;
        }

        public double BaseArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double TotalArea()
        {
            double slantHeight = Math.Sqrt(Math.Pow(Radius, 2) + Math.Pow(Height, 2));
            return BaseArea() + Math.PI * Radius * slantHeight;
        }
    }
}
}
