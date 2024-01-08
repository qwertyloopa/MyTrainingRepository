using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1._8._2
{
    public class Plane : Transport
    {
        public Plane(Engine engine) : base(engine)
        {
            
        }

        public override Engine Engine
        {
            get => this.Engine;
            set
            {
                if (value is PlaneEngine)
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
            Console.WriteLine("fly a high");
        }
    }
}
