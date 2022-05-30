using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal class WindowsFileSystemReciver : IFileSystemReciver
    {
        public void CloseFile()
        {
            Console.WriteLine("Closing File in Windows");
        }

        public void OpenFile()
        {
            Console.WriteLine("Opening File in Windows");
        }

        public void WriteFile()
        {
            Console.WriteLine("Writing File in Windows");
        }
    }
}
