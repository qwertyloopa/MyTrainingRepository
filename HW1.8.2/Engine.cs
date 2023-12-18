using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1._8._2
{
    public abstract class Engine
    {
        private bool isStarted = false;
        public void StartEngine()
        {
            if(!isStarted) 
            {
                isStarted = true;
            }
        }

        public class CarEngine : Engine { }
        public class PlaneEngine : Engine { }
    }

}
