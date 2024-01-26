using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ4
{
    internal class FitnessCenter
    {
        public int year;
        public int month;
        public int duration;
        public int clientCode;

        public FitnessCenter(int year, int month, int duration, int clientCode)
        {
            this.year = year;
            this.month = month;
            this.duration = duration;
            this.clientCode = clientCode;
        }
    }
}
