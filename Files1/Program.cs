namespace Files1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Directories direct = new Directories("../Folder/");

            int countOfFiles = Directories.GetCountOfFile(direct.FilePath);
            Console.WriteLine($"Количество файлов в папке: {countOfFiles}");
            
            List<FileInfo> fileInfo = Directories.GetFileInfo(direct.FilePath);
            foreach(FileInfo f in fileInfo)
            {
                Console.WriteLine($"Файл {f.Name}, Размер файла: {f.Length}, Последний раз открывался: {f.LastAccessTime}.");
            }

            Console.ReadKey();
        }
    }
}