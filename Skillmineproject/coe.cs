using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject
{
    class coe
    {
        static void Main(string[] args)
        {
            int ce=0, co=0;
            int no = int.Parse(Console.ReadLine());
              for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    ce++;
                }
                else
                {
                    co++;
                }
            }

            Console.Write(ce);
            Console.Write(" ");
            Console.Write(co);
        }
    }
}
