using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal class CloseFileCommand : ICommand
    {
        private IFileSystemReciver fileSystem;
        public CloseFileCommand(IFileSystemReciver fs)
        {
            fileSystem = fs;
        }
        public void Execute()
        {
            fileSystem.CloseFile();
        }
    
    }
}
