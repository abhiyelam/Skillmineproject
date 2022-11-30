using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject.method
{
    class Car
    {
        int model_no;
        String name;
        String color;
        String price;
        public void AcceptDetails(int model_no,String name,String color,String price)
        {
            this.model_no = model_no;
            this.name= name;
            this.color = color;
            this.price = price;

        }
        public void Show()
        {
            Console.WriteLine(model_no+" "+name+" "+color+" "+price);
        }
        static void Main(string[] args)
        {
            Car c = new Car();
            Car c1 = new Car();
            Car c2 = new Car();

            c.AcceptDetails(123, "swift", "Red", "15lakh");
            c1.AcceptDetails(124, "Altroz", "orange", "5 lakh");
            c2.AcceptDetails(125, "Maruti suzuki", "white", "8 lakh");

            c.Show();
            c1.Show();
            c2.Show();
        }
    }
    class Factor
    {
        public int SumFactor(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    sum = sum + i;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Factor f = new Factor();
            //int result=f.SumFactor(6);
            Console.WriteLine(f.SumFactor(6));
        }

    }

    class addition
    {
        public int Sum(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int rem = n % 10;
                sum = sum + rem;
                n = n / 10;
            }
            return sum;
        }
        public static void Main(string[] args)
        {
            addition s = new addition();

            Console.WriteLine(s.Sum(123));
        }
    }

    class SumFactorial
    {
        public int Factorial(int n)
        {
            
            int fact = 0;
            for(int i = 1; i <= n; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    fact = fact + i;
                }
            }
            return fact ;
        }
        static void Main(string[] args)
        {
            SumFactorial f1 = new SumFactorial();
            Console.WriteLine(f1.Factorial(5));
        }
    }
    
    

    
}

