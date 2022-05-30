using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal class FileInvoker
    {
         ICommand command;
        public FileInvoker(ICommand c)
        {
            command = c;
        }
        public void Execute()
        {
            command.Execute();
        }
    }
}
