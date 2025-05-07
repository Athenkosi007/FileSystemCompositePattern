using System;
using FileSystemCompositePattern;

public class FileItem : IFileSystemItem
{
    private string _name;

    public FileItem(string name)
    {
        _name = name;
    }

    public void Display(int indent = 0)
    {
        Console.WriteLine(new string('-', indent) + _name);
    }
}
