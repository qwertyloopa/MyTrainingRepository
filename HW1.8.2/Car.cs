using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1._8._2
{
    public class Car : Transport
    {
        public Car(Engine engine) : base(engine)
        {
        }

        public override Engine Engine
        {
            get => this.Engine;
            set
            {
                if (value is CarEngine)
                {
                    this.Engine = value;
                }
            }
        }



        public override void Move()
        {
            Engine.StartEngine();
            FlyAHigh();
        }

        public void FlyAHigh()
        {
            Console.WriteLine("Take a speed");
        }
    }
}
