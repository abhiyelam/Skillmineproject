using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject
{
    class Prime
    {
        static void Main(string[] args)
        {
           Console.WriteLine("enter the no");
            int num = int.Parse(Console.ReadLine());
            int m = 0;
            for(int i = 2; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("no is not prime");
                        m = 1;
                    break;

                }
            }
            if (m == 0)
                Console.WriteLine("no is prime");
        }
    }
}
