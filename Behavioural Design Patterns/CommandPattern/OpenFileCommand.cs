using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal class OpenFileCommand : ICommand
    {
        private IFileSystemReciver fileSystem;
        public OpenFileCommand(IFileSystemReciver fs)
        {
            fileSystem = fs;
        }
        public void Execute()
        {
            fileSystem.OpenFile();
        }
    
    }
}
