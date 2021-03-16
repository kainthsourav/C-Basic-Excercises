using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Enter numbers sperated by a hyphen ");
            var data = Console.ReadLine();

            List<int> numbers = new List<int>();
            string[] stringNum = data.Split("-");
            foreach (var item in stringNum)
            {
                numbers.Add(Convert.ToInt32(item));
            }

            numbers.Sort();

            Boolean consecutive = true;
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] != numbers[i - 1] + 1)
                {
                    consecutive = false;
                    break;
                }
            }
            var isConsecutive = consecutive ? "consecutive" : "Not consecutive";
            Console.WriteLine(isConsecutive);
        }
    }
}
