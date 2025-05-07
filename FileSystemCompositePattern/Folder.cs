using System;
using System.Collections.Generic;
using FileSystemCompositePattern;

public class Folder : IFileSystemItem
{
    private string _name;
    private List<IFileSystemItem> _children = new List<IFileSystemItem>();

    public Folder(string name)
    {
        _name = name;
    }

    public void Add(IFileSystemItem item)
    {
        _children.Add(item);
    }

    public void Display(int indent = 0)
    {
        Console.WriteLine(new string('-', indent) + $"[Folder] {_name}");
        foreach (var child in _children)
        {
            child.Display(indent + 2);
        }
    }
}