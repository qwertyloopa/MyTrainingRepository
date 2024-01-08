using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1._8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Engine.CarEngine electro = new Engine.CarEngine();
            Engine.PlaneEngine reactive = new Engine.PlaneEngine();
            Car car = new Car(electro);
            Plane plane = new Plane(reactive);
        }
    }
}