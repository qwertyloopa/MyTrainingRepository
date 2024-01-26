namespace LINQ4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<FitnessCenter> trainings = new List<FitnessCenter>();
            trainings.Add(new FitnessCenter(2004, 12, 2, 1337));
            trainings.Add(new FitnessCenter(2008, 9, 4, 1488));
            trainings.Add(new FitnessCenter(2004, 5, 5, 1677));
            trainings.Add(new FitnessCenter(2004, 5, 2, 1991));
            trainings.Add(new FitnessCenter(2013, 12, 6, 1337));
            trainings.Add(new FitnessCenter(2004, 12, 2, 1337));
            trainings.Add(new FitnessCenter(2008, 6, 2, 1337));
            trainings.Add(new FitnessCenter(2004, 7, 2, 1337));
            Console.WriteLine("Я еблан и это не обсуждается");
            
            List<FitnessCenter> fitnesses = new List<FitnessCenter>();
            foreach(FitnessCenter fitness in trainings)
            {
                var result = trainings.OrderByDescending(x => x.duration).ThenByDescending(x => x.year).FirstOrDefault();
                fitnesses.Add(new FitnessCenter(result.year, result.month, result.duration, result.clientCode));
                Console.WriteLine($"{result.year}, {result.month}, {result.duration}, {result.clientCode}");
            }
        }
    }
}