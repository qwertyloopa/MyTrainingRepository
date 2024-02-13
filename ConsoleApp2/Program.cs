namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Ivan","Ivanov"));
            students.Add(new Student("John", "Doe"));

            School school = new School(students);
            Predicate<Student> prStudent = prStudent => prStudent.first_name == "John" & prStudent.last_name == "Doe";
            var result = school.FindStudent(prStudent);
            Console.WriteLine($"{result.first_name} {result.last_name}");
        }
    }
}