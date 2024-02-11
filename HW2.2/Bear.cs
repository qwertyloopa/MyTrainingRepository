namespace HW2._2
{
    internal class Bear : Animal, ICarnivore, IHerbivore
    {
        string sound { get; set; }
        string color { get; set; }

        public Bear(string sound, string color)
        {
            this.sound = sound;
            this.color = color;
        }
        public string typeH { get ; set; }
        public string foodH { get; set; }
        public string typeC { get; set; }
        public string foodC { get; set; }

        public override void displayAnimal()
        {
            throw new NotImplementedException();
        }

        public void DisplayEatC()
        {
            throw new NotImplementedException();
        }

        public void DisplayEatH()
        {
            throw new NotImplementedException();
        }
    }
}
