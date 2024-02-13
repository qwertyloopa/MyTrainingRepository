using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class StudentEventArgs : EventArgs
    {
        public Student Student { get; set; }
        public StudentEventArgs(Student student) 
        {
            Student = student;
        }
    }
}
