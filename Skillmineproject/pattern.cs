using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject
{
    class pattern
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 4; i++)
            {
                for(int j = 1; j <= 4; j++)
                {
                    if (i >= j)
                    {
                        Console.Write(j);
                        
                    }
                    else
                    {
                        Console.WriteLine("");
                    }
                    
                }
            }
            

        }
    }

    class pattern2
    {
        public static void Main(string[] args)
        {
            for(int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= 5; j++)
                {
                    if (i <= j)
                    {
                        Console.Write(j +" ");
                    }
                    else
                    {
                        Console.WriteLine(" ");
                    }
                }
            }
        }
    }


    class pattern3
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    if (i == 4 || j==1 ||  i==2&&j==2 && i==3&&j==3)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.WriteLine(" ");
                    }
                }
            }
        }
    }
    class pattern5
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    if (i>=j)
                    {
                        Console.Write((char)(j+64));
                    }
                    else
                    {
                        Console.WriteLine("");
                    }
                }
            }
        }
    }
}


