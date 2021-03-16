using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class VaildInvaildTime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Time : ");
            var time = Console.ReadLine();
            if(!string.IsNullOrEmpty(time))
            {
                var VaildTime = time.Split(":");
                if (VaildTime.Length != 2)
                {
                    Console.WriteLine("Invaild Time");
                    return;
                }
                else
                {
                    var hour = Convert.ToInt32(VaildTime[0]);
                    var mint = Convert.ToInt32(VaildTime[1]);
                    if(hour>=0 && hour<=23 && mint>=0 && mint<=59)
                    {
                        Console.WriteLine("OK");
                    }
                    else
                    {
                        Console.WriteLine("Invaild Time");
                    }
                }
            }
        }
    }
}
