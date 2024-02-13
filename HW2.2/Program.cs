namespace HW2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bear freddy = new Bear("Freddy", 4, "BEAAAR", "brown", "carnivore", "herbivore", "meat and fish", "berries");
            freddy.DisplayAnimal();

            Cat larry = new Cat("Larry", 4, "Meow", "Brown", "carnivore", "rats");
            larry.DisplayAnimal(); larry.DisplayEat();

            Cat barsik = new Cat("Barsik", 4, "Meow", "Brown", "carnivore", "meat");
            barsik.DisplayAnimal(); barsik.DisplayEat();

            Elephant jumbo = new Elephant("Jumbo", 4, "PHP", "gray", "herbivore", "bananas");
            jumbo.DisplayAnimal(); jumbo.DisplayEat();

            List<Animal> animals = new List<Animal> { larry, freddy, jumbo };
            Zoo londonZoo = new Zoo(animals);

            londonZoo.SortByType();
            londonZoo.DisplayAnimals();
        }
    }
}