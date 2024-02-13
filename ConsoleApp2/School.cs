using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    
    internal class School
    {
        public delegate StudentEventArgs NewStudentEvent(Student student);
        public event NewStudentEvent notify;

        private List<Student> students;

        public School(List<Student> studentss) 
        {
            students = studentss;
        }

        public Student? FindStudent(Predicate<Student> prStudent) {
            var student = this.students.Find(prStudent);
            return student;
        }

        public void AddStudent(Student student)
        {
            notify.Invoke(student);
            students.Add(student);
        }
        
    }
}
