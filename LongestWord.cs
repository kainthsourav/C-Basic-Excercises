using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp3
{
   public class LongestWord
    {
        static void Main(string[] args)
        {
            string path = @"G:\Phone Data\Desktop\Interview.txt";
            var wordnum = new List<string>(File.ReadAllText(path).Split(' '));
            int length = 0;
            string lword="";
            foreach (var item in wordnum)
            {
                if(item.Length>length)
                {
                    lword = item;
                }
            }
            Console.WriteLine(lword);
        }
    }
}
