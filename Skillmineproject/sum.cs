using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject
{
    class sum
    {
        static void Main(string[] args)
        {
            int i = 1;
            int sum = 0;
            while (i <= 20)

                if (i % 2 != 0)
                {
                    sum = sum + i;
                    i++;
                }

            Console.WriteLine(sum);
        }
            
    }
}
