namespace HW2._4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            try
            {
                Console.WriteLine("Введите число");
                number = int.Parse(Console.ReadLine());
            } catch (NullReferenceException nrex)
            {
                Console.WriteLine("Объект пустой " + nrex.Message);
            } catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Очень большое число " + ex.Message);
            } catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            } catch (FormatException ex)
            {
                Console.WriteLine("Проблемы с парсингом " + ex.Message);
            } finally 
            {
                number++;
                Console.WriteLine(number); 
            }

            Console.ReadKey();
        }
    }
}