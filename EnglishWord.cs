using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    class EnglishWord
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word");
            var data = Console.ReadLine().ToLower();
            var vowels = new List<char>(new char[] { 'a', 'e', 'o', 'u', 'i' });
            var count = 0;
            foreach (var item in data)
            {
                if(vowels.Contains(item))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
