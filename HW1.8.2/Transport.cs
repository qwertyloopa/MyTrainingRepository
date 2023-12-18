using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1._8._2
{
    public abstract class Transport : Engine
    {
        public abstract Engine Engine 
        {
            get; set;
        }

        public Transport(Engine engine) => Engine = engine;

        public abstract void Move();
    }
}
