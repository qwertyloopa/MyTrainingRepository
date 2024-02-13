namespace HW2._2
{
    class Bear : Animal, ICarnivore, IHerbivore
    {
        public string Sound { get; set; }
        public string Colour { get; set; }
        public string Type { get; set; }
        public string Food { get; set; }


        public Bear(string name, int numOfLegs, string sound, string colour, string carnivoreType, string herbivoreType, string carnivoreFood, string herbivoreFood) : base(name, numOfLegs)
        {
            Sound = sound;
            Colour = colour;
            (this as ICarnivore).Type = carnivoreType;
            (this as IHerbivore).Type= herbivoreType;
            (this as ICarnivore).Food = carnivoreFood;
            (this as IHerbivore).Type = herbivoreFood;
        }

        public override void DisplayAnimal()
        {
            Console.WriteLine($"Name: {Name}, NumOfLegs: {NumOfLegs}, Sound: {Sound}, Colour: {Colour}, CarnivoreType: {(this as ICarnivore).Type}, HerbivoreType: {(this as IHerbivore).Type}");
        }

        public void DisplayEat()
        {
            Console.WriteLine($"{Name} eats {Food}");
        }
    }
}
