using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2._2._4
{
    internal class Person : IComparable<Person>
    {
        public int age;
        public Gender gender;

        int IComparable<Person>.CompareTo(Person? other)
        {
            if (other is Person)
            {
                if ((age == other.age && gender == Gender.Female && other.gender == Gender.Male) || age > other.age)
                    return 1;
                if (age < other.age)
                    return -1;
                else return 0;
            }
            else
                throw new ArgumentException();

        }
        public Person(int age, Gender gender)
        {
            this.age = age;
            this.gender = gender;
        }
    }

    enum Gender
    {
        Male,
        Female
    }
}
