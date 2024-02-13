namespace HW2._1._2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            GroundBeans gb = new GroundBeans(Strength.Medium, 5);
            Water bonaqua = new Water(95, 7);

            Coffee arabica = gb.MakeACoffee(gb.Strength, gb.Volume);

            Coffee drink = bonaqua + arabica;

            Console.WriteLine(drink.ToString());
        }
    }
}
