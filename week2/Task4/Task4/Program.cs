using System;
using System.IO;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = "C:/Users/batiq/Desktop/pp2/week2/Task3";
            string path2 = "/Users/batiq/Desktop/pp2/week2/Task4";
            string firstFile = Path.Combine(path1, "newFile.txt");
            string copyOfFile = Path.Combine(path2, "newFile.txt");

            

            FileStream fs = File.Create(firstFile);
            fs.Close();
            File.Copy(firstFile, copyOfFile, true);

        }
    }
}