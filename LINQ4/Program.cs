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
            
         
            var result = trainings.GroupBy(x => x.year).Select(g => new { year = g.Key, totalDuration = g.Sum(x => x.duration) }).OrderByDescending(x => x.totalDuration).First();
            Console.WriteLine($"Год по продолжительности {result.year}, Суммарная продолжительность: {result.totalDuration}");            
        }
    }
}