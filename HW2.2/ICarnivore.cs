using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2._2
{
    interface ICarnivore
    {
        public string Type { get; set; }
        public string Food { get; set; }

        void DisplayAnimal();

        public void DisplayEat();
    }
}
