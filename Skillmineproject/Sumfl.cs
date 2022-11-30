using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject
{
    class Sumfl
    {
        static void Main(string[] args)
        {
            int fd=0;
            int ld;
            int sum = 0;
            Console.WriteLine("Enter the no");
            int num = int.Parse(Console.ReadLine());
            
            ld = num % 10;
            while(num!=0)
            {
                fd = num % 10;
                num = num / 10;
            }
            sum = ld + fd;
            Console.WriteLine(sum);
        }
    }
}
