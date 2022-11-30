using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject.Array
{
    class Array10
    {
        public void Display(int[] arr)
        {
            //for(int i = 0; i < arr.Length; i++)
           // {
                if(arr[0]==1 || arr[arr.Length] == 1)
                {
                    Console.WriteLine("YES");
                }
            //}
        }
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Array10 ar = new Array10();
            ar.Display(arr);
            
        }
    }
}
