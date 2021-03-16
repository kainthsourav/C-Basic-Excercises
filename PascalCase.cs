using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class PascalCase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Words");
            var data = Console.ReadLine();

            if(!string.IsNullOrEmpty(data))
            {
                var statement= "";
                foreach (var item in data.Split(" ")) 
                {
                    var pascalCase = char.ToUpper(item[0])+item.ToLower().Substring(1);
                    statement += pascalCase;

                }
                Console.WriteLine(statement);

            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
