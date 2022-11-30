using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject
{
    class month
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Enter the no");
            int no = int.Parse(Console.ReadLine());
            switch (no)
            {
                case 1:
                    Console.WriteLine("jan - 31");
                    break;
                case 2:
                    Console.WriteLine("feb - 28");
                    break;
                case 3:
                    Console.WriteLine("march - 31");
                    break;
                case 4:
                    Console.WriteLine("April - 30");
                    break;
                case 5:
                    Console.WriteLine("may - 31");
                    break;
                case 6:
                    Console.WriteLine("june - 30");
                    break;
                case 7:
                    Console.WriteLine("july - 31");
                    break;
                case 8:
                    Console.WriteLine("Aug - 31");
                    break;
                case 9:
                    Console.WriteLine("sep - 30");
                    break;
                case 10:
                    Console.WriteLine("oct - 31");
                    break;
                case 11:
                    Console.WriteLine("nov - 30");
                    break;
                case 12:
                    Console.WriteLine("des - 31");break;
                   // break;
                default:
                    Console.WriteLine("invalid input");break;





            }
           
        }   
    }

    class calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first no");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second no");
            int y = int.Parse(Console.ReadLine());
            
            Console.WriteLine("1.Add\n 2.sub\n 3.mul\n 4.div");
            Console.WriteLine("Enter the choice");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    //int z = x + y;
                    Console.WriteLine("Add =" +(x+y)); break;
                case 2:
                    Console.WriteLine("sub="+(x - y)); break;
                case 3:
                    Console.WriteLine(x * y); break;
                case 4:
                    Console.WriteLine(x / y); break;
                default:
                    Console.WriteLine("invalid");
                    break;

            }


        }
    }
 
 
    
        class vowel
        {
             static void Main(string[] args)
            {
                char ch;
                Console.WriteLine("Enter an alphabet");
                ch = Convert.ToChar(Console.ReadLine());

                switch (Char.ToLower(ch))
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        Console.WriteLine("Vowel");
                        break;
                    default:
                        Console.WriteLine("Not a vowel");
                        break;
                }
            }
        }
    

}
