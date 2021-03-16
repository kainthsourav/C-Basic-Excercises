using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    public class Duplicate
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers sperated by a hyphen ");
            var data = Console.ReadLine();
            if(!string.IsNullOrEmpty(data))
            {
                Boolean duplicate = false;
                List<int> uniqueNumbers = new List<int>();
                string[] stringNum = data.Split("-");
                foreach (var item in stringNum)
                {
                 if(!uniqueNumbers.Contains(Convert.ToInt32(item)))
                    {
                        uniqueNumbers.Add(Convert.ToInt32(item));
                    }
                 else
                    {
                        duplicate = true;
                        break;
                    }
                }

                if(duplicate)
                {
                    Console.WriteLine("Duplicate");
                }
                
            }
            Console.ReadLine();

            

        }
    }

}


        