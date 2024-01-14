namespace HW2._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var word in FilterWords(GenerateRandomWords(3)))
            {
                Console.WriteLine(word);
            }
        }

        static IEnumerable<string> FilterWords(IEnumerable<string> words)
        {
            foreach (var word in words)
            {
                if (word.Length > 5)
                {
                    yield return word;
                }
            }
        }

        static IEnumerable<string> GenerateRandomWords(int count)
        {

            Dictionary<int, string> dictionary = new Dictionary<int, string>
            {
                { 0, "словарь" },
                { 1, "генератор" },
                { 2, "метод" },
                { 3, "программа" },
                { 4, "компьютер" },
                { 5, "информация" },
                { 6, "технология" },
                { 7, "разработка" },
                { 8, "алгоритм" },
                { 9, "структура" }
            };

            var random = new Random();
            for (int i = 0; i < count; i++)
            {
                int index = random.Next(dictionary.Count);
                yield return dictionary[index];
            }
        }
    }
}