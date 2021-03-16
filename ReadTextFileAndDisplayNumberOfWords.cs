using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp3
{
    class ReadTextFileAndDisplayNumberOfWords
    {
        static void Main(string[] args)
        {
            string path = @"G:\Phone Data\Desktop\Interview.txt";
            var num = new List<string>(File.ReadAllText(path).Split(' '));
            Console.WriteLine(num.Count);
        }

    }
}
