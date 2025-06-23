# FileSystemCompositePattern

This project demonstrates the Composite Design Pattern using a File System simulation. It shows how individual objects (files) and composite objects (folders) can be treated uniformly under a common interface, enabling tree-like structures to be traversed and managed seamlessly. Perfect for understanding how to work with hierarchical data structures in a clean, maintainable way.. 

| Class/File           | Description                                                  |
| -------------------- | ------------------------------------------------------------ |
| `IFileSystemItem.cs` | The **Component** interface (declares `Display()`)           |
| `FileItem.cs`        | The **Leaf** class (represents a file)                       |
| `Folder.cs`          | The **Composite** class (represents a folder with children)  |
| `Program.cs`         | The **Client** code that builds and displays the file system |

