using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject
{
    class DN
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no");
            int no = int.Parse(Console.ReadLine());
            int length = 0;
            int sum = 0;
            int original = no;
            String s = Convert.ToString(no);
            length = s.Length;
            no=original;
            while (no > 0)
            {
                int power = 1;
                int r = no % 10;
                for(int i=1;i<=length;i++)
                {
                    power = power * r;
                }
                sum = sum + power;
                length--;
                no = no / 10;

           }
            if(original==sum)
            {
                Console.WriteLine("Disarium no");
            }
            else
            {
                Console.WriteLine("this is not Disarium no");
            }
        }
    }
}
//Math.Pow(di)