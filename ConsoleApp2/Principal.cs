using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static ConsoleApp2.School;

namespace ConsoleApp2
{
    internal class Principal
    {
        public string SendWelcomeMessage(Student student, School school)
        {

            string message = $"Уважаемые родители {student.first_name} {student.last_name}!\n" +
                             "Мы рады приветствовать вас в нашей школе.\n" +
                             "С уважением, директор школы.";
            return message;
        }

        public void OnStudentAdded(object sender, StudentEventArgs e)
        {
            string message = SendWelcomeMessage(e.Student, sender as School);
            Console.WriteLine(message);
        }
    }
}
