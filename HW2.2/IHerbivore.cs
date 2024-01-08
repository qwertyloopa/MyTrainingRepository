using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2._2
{
    internal interface IHerbivore
    {
        string typeH { get; set; }
        string foodH { get; set; }

        public void DisplayEatH() => Console.WriteLine(foodH);
    }
}
