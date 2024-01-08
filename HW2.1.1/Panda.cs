using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2._1._1
{
    class Panda
    {
        Random rnd = new Random();
        public string Name { get; set; }
        public int HP { get; set; }
        public int Defence { get; set; }
        public int Attack { get; set; }
        Gender Gen { get; set; }
        Color Col { get; set; }

        public Panda(string Name, Color color)
        {
            int genderRandom = rnd.Next(1, 2);
            int colorRandom = rnd.Next(1, 3);
            this.Name = Name;
            HP = rnd.Next(20, 40);
            Defence = rnd.Next(5, 10);
            Attack = rnd.Next(5, 10);
            Gen = (Gender)genderRandom;
            Col = (Color)colorRandom;
        }



        public static Panda operator +(Panda p1, Panda p2)
        {
            if (p1.Gen != p2.Gen)
            {
                return new Panda { Name = Console.ReadLine(), HP = p1.HP, Defence = p2.Defence, Attack = p2.Attack };
            }
            else
            {
                return null;
            }
        }

        public static Panda operator -(Panda p1, Panda p2)
        {
            if (p1.Attack < p2.Attack)
            {
                p1.HP -= p2.Attack;
            }
            else if (p1.Attack > p2.Attack)
            {
                p2.HP -= p1.Attack;
            }
            else
            {

            }
        }
    }

    public enum Gender
    {
        Male,
        Female
    };

    public enum Color
    {
        Black,
        White,
        BlackAndWhite,
    }
}
