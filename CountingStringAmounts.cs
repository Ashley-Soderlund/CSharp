using System;
using System.IO;

namespace FileHomeworkConsol1
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileContents = File.ReadAllText("sample.txt");

            string[] lines = fileContents.Split('\n');
            int lineCount = lines.Length;
            int charCount = fileContents.Length;
            int wordCount = 0;

            if(fileContents.Length == 0)
            {
                Console.WriteLine("File is Empty");
                lineCount = 0;
                charCount = 0;
            }
            else
            {
                wordCount = 1;
                int x = 0;
                while (x <= charCount - 1)
                {
                    if (fileContents[x] == ' ' || fileContents[x] == '\n')
                    {
                        wordCount++;
                    }
                    x++;
                }
            }

            Console.WriteLine("Number of lines: " + lineCount);
            Console.WriteLine("Number of words: " + wordCount);
            Console.WriteLine("Number of characters: " + charCount);
            Console.WriteLine("In this text: " + '\n' + fileContents);
        }
    }
}
