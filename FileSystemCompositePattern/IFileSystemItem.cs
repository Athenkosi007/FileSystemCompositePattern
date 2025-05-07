using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemCompositePattern
{
    public interface IFileSystemItem
    {
        void Display(int indent = 0);
    }
}
