namespace HW2._3._3;

public class Program {
    static void Main(string[] args)
    {
        var stringProcessor = new StringProcessor();
        
        try
        {
            stringProcessor.ProcessString("");
        } catch (EmptyStringException ex)
        {
            Console.WriteLine(ex.Message);
        }
        
    }
}