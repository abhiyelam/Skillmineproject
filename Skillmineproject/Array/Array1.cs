using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject.Array
{
    class ArrayDemo
    {
        static void Main()
        {
            int[] arr = new int[5];
            Console.WriteLine("enter the array element");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("array element");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);

            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
    //sum of even element
    class Array1
    {
        public void SumofEven(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sum = sum + arr[i];
                }
            }
            Console.WriteLine("sum of even element is=" + sum);
        }
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter the array element ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            Array1 ar = new Array1();
            ar.SumofEven(arr);

        }
    }

    //max no from array
    class Array2
    {
        public void Max(int[] a)
        {
            int max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            Console.WriteLine("max element is=" + max);
        }
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter the array element");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Array2 ar = new Array2();
            ar.Max(arr);
        }
    }

    // minimum element from array
    class Array3
    {
        public void Min(int[] a)
        {
            int min = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            Console.WriteLine("min element is=" + min);
        }
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter the array element");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Array3 ar = new Array3();
            ar.Min(arr);
        }
    }

    //count of odd element from array
    class Array4
    {
        public void CountOfOdd(int[] a)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)
                    count++;
            }
            Console.WriteLine("count of odd elements=" + count);

        }
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter array element");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Array4 ar = new Array4();
            ar.CountOfOdd(arr);

        }
    }

    //print char type array
    class Array5
    {
        static void Main(string[] args)
        {
            char[] ch = new char[5];
            Console.WriteLine("Enter the character");
            for (int i = 0; i < ch.Length; i++)
            {
                ch[i] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("character of array");
            for (int i = 0; i < ch.Length; i++)
            {
                Console.WriteLine(ch[i]);
            }
            Console.WriteLine(string.Join(" ", ch));
        }

    }

    //display vowels from array
    class Array6
    {
        public void DisplayVowels(char[] ch)
        {
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == 'a' || ch[i] == 'e' || ch[i] == 'i' || ch[i] == 'o' || ch[i] == 'u')
                {
                    Console.WriteLine(ch[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            char[] ch = new char[5];
            Console.WriteLine("Enter the character ");
            for (int i = 0; i < ch.Length; i++)
            {
                ch[i] = Convert.ToChar(Console.ReadLine());
            }
            Array6 ar = new Array6();
            ar.DisplayVowels(ch);
        }
    }

    //sum of array element;
    class Array7
    {
        public void DisplaySum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }

            Console.WriteLine("sum of  element is=" + sum);
        }
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter the array element ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine()); 

            }
            Array7 ar = new Array7();
            ar.DisplaySum(arr);

        }

    }

    // replace the element by zero if is divisible by 3
    class Array8
    {
        public void ReplacebyZero(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 3 == 0)
                {
                    arr[i] = 0;
                }
                
            }
            Console.WriteLine("________________");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter the array element");
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i]=int.Parse(Console.ReadLine());
            }
            Array8 ar = new Array8();
            ar.ReplacebyZero(arr);
        }
    }
}