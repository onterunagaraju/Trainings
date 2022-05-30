using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFileSystemReciver fs = new WindowsFileSystemReciver();
            ICommand command = new OpenFileCommand(fs);
            FileInvoker invoke = new FileInvoker(command);
            invoke.Execute();

            fs = new LinuxFileSystemReciver();
             command = new OpenFileCommand(fs);
            invoke = new FileInvoker(command);
            invoke.Execute();

            Console.ReadLine();
        }
    }
}
