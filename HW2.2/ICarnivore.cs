using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2._2
{
    internal interface ICarnivore
    {
        public abstract string typeC { get; set; }
        public abstract string foodC { get; set; }

        public void DisplayEatC();
    }
}
