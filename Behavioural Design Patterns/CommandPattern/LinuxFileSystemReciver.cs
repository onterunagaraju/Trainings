using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal class LinuxFileSystemReciver : IFileSystemReciver
    {
        public void CloseFile()
        {
            Console.WriteLine("Closing File in Linux");
        }

        public void OpenFile()
        {
            Console.WriteLine("Opening File in Linux");
        }

        public void WriteFile()
        {
            Console.WriteLine("Writing File in Linux");
        }
    }
}
