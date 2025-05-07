namespace FileSystemCompositePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var root = new Folder("Root");

            var file1 = new FileItem("File1.txt");
            var file2 = new FileItem("File2.txt");

            var subFolder1 = new Folder("SubFolder1");
            subFolder1.Add(new FileItem("File3.txt"));
            subFolder1.Add(new FileItem("File4.txt"));

            var subFolder2 = new Folder("SubFolder2");
            subFolder2.Add(new FileItem("File5.txt"));

            root.Add(file1);
            root.Add(file2);
            root.Add(subFolder1);
            root.Add(subFolder2);

            // Display full structure
            root.Display();

            Console.ReadLine();
        }
    }
}
