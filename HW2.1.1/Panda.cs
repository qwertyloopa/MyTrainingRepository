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
        public string? name { get; set; }
        public int hp { get; set; }
        public int defence { get; set; }
        public decimal weight { get; set; }
        public int attack { get; set; }
        Gender gen { get; set; }
        Color col { get; set; }

        public Panda(string name)
        {
            int genderRandom = rnd.Next(1, 2);
            int colorRandom = rnd.Next(1, 3);
            this.name = name;
            this.hp = rnd.Next(20, 40);
            this.defence = rnd.Next(5, 10);
            this.attack = rnd.Next(5, 10);
            this.gen = (Gender)genderRandom;
            this.col = (Color)colorRandom;
        }



        public static Panda operator +(Panda p1, Panda p2)
        {
            if (p1.gen != p2.gen)
            {
                Console.WriteLine("Вы застали рождение новой панды, придумайте ей имя");
                return new Panda(Console.ReadLine());
            }
            else
            {
                return null;
            }
        }

        public static Panda operator -(Panda p1, Panda p2)
        {
            if (p1.attack < p2.attack)
            {
                p1.hp -= p2.attack;
                return p1;
            }
            else if (p1.attack > p2.attack)
            {
                p2.hp -= p1.attack;
                return p2;
            }
            else if(p2.hp == 1 | p1.hp == 1)
            {
                return null;
            }
            else 
            {
                return null;
            }
        }

        public override string ToString()
        {
            string result = $"{this.name}, {this.hp}, {this.gen}";
            return result;
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
