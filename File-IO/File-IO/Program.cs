using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_IO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileOperation fileOperation = new FileOperation();
            fileOperation.FileExists();
            fileOperation.ReadAllLines();
            fileOperation.ReadAllText();
            fileOperation.CopyFile();
            fileOperation.DeleteFile();
            Console.ReadLine();
        }
    }
}
