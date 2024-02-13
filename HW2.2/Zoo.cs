using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2._2
{
    internal class Zoo
    {
        public List<Animal> Animals { get; private set; }
        public List<IHerbivore> Herbivores { get; private set; }
        public List<ICarnivore> Carnivores { get; private set; }

        public Zoo(List<Animal> animals)
        {
            Animals = animals;
            Herbivores = new List<IHerbivore>();
            Carnivores = new List<ICarnivore>();
        }

        public void SortByType()
        {
            foreach (var animal in Animals)
            {
                if (animal is IHerbivore herbivore)
                {
                    Herbivores.Add(herbivore);
                }
                if (animal is ICarnivore carnivore)
                {
                    Carnivores.Add(carnivore);
                }
            }
            Herbivores.Sort((a, b) =>
            {
                string aType = a.Type ?? "Unknown";
                string bType = b.Type ?? "Unknown";
                return aType.CompareTo(bType);
            });

            Carnivores.Sort((a, b) =>
            {
                string aType = a.Type ?? "Unknown";
                string bType = b.Type ?? "Unknown";
                return aType.CompareTo(bType);
            });

        }   

        public void DisplayAnimals()
        {
            Console.WriteLine("Herbivores:");
            foreach (var herbivore in Herbivores)
            {
                herbivore.DisplayAnimal();
                Console.WriteLine();
            }

            Console.WriteLine("Carnivores:");
            foreach (var carnivore in Carnivores)
            {
                carnivore.DisplayAnimal();
                Console.WriteLine();
            }
    }
}
}
