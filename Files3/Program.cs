using System.Text;
using System.IO;

namespace Files3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            read();
        }
        static async Task read()
        {
            string path = "../TestFile.txt";
            using (FileStream fstream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {

                byte[] buffer = new byte[fstream.Length];
                //foreach(byte b in buffer) Console.Write(b+", ");
                await fstream.ReadAsync(buffer, 0, buffer.Length);
                string textFromFile = Encoding.Default.GetString(buffer);
                Console.WriteLine($"Текст из файла: {textFromFile}");
            } 
        }
    }
}
