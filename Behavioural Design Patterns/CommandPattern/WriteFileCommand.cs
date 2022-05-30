using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal class WriteFileCommand : ICommand
    {
        private IFileSystemReciver fileSystem;
            public WriteFileCommand(IFileSystemReciver fs)
        {
            fileSystem = fs;
        }
        public void Execute()
        {
            fileSystem.WriteFile();
        }
    }
}
