using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_IO
{
    //File is a collection of data stored in a disk with the specific name and a directory path.
    //File is open for reading and writing it become a stream
    //Stream is a sequence of byte passing throough a communication path.
    //The namespace we are using is System.IO
    //Input Stream- Reading Input data from a file.
    //Output Stream- Writing the data into a file.
    internal class FileOperation
    {
        string filePath = "C:\\Users\\nsure\\OneDrive\\Desktop\\PFP 002\\File-IO\\File-IO\\File-IO\\Jashu.txt";
        string path = @"C:\Users\nsure\OneDrive\Desktop\PFP 002\File-IO\File-IO\File-IO\Jashu.txt";
        public void FileExists()
        {
            if (File.Exists(filePath))
            {
                Console.WriteLine("File Exists.");
            }
            else
            {
                Console.WriteLine("File not exists.");
            }
        }
        public void ReadAllLines()
        {
            string[] strings = File.ReadAllLines(filePath);
            foreach (string line in strings)
            {
                Console.WriteLine(line);
            }
        }
        public void ReadAllText()
        {
            string line = File.ReadAllText(filePath);
            Console.WriteLine(line);
        }
        public void CopyFile()
        {
            string copyFilePath = "C:\\Users\\nsure\\OneDrive\\Desktop\\PFP 002\\File-IO\\File-IO\\File-IO\\Kumar.txt";
            File.Copy(filePath, copyFilePath);
            Console.WriteLine("File is copied.");
        }
        public void DeleteFile()
        {
            string copyFilePath = "C:\\Users\\nsure\\OneDrive\\Desktop\\PFP 002\\File-IO\\File-IO\\File-IO\\Kumar.txt";
            File.Delete(copyFilePath);
            Console.WriteLine("File is deleted.");
        }

    }
}
