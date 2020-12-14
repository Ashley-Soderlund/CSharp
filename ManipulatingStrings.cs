using System;
using System.IO;

namespace FileHomeworkConsol2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "sample.txt"; //Must change this value to access a different file
            string fileContents = File.ReadAllText(fileName);
            Console.WriteLine("This file's text says: " + '\n' + fileContents + '\n');
            
            string[] fileLines = fileContents.Split('\n');

            int x = 0;
            int i = 1;

            foreach (string line in fileLines)
            {
                if(x == 0)
                {
                    string output = i + " " + fileLines[x] + '\n';
                    fileContents = output;
                }
                else
                {
                    string output = i + " " + fileLines[x] + '\n';
                    fileContents = fileContents + output;
                }

                i++;
                x++;
            }

            string nameOfFile = fileName.Replace(".txt", "_ln") + ".txt";
            File.WriteAllText(nameOfFile, fileContents);
            Console.WriteLine("The program numbers off each line. The new file's text says: " + '\n' + fileContents + '\n');
            Console.WriteLine("The updated file was saved as " + nameOfFile);
        }
    }
}
