using System;
using System.Collections.Generic;
using System.Text;

namespace ConflictChecking
{
    public class ConflictCheck
    {
        int num1=0, num2 = 1; 
        int num3;
       public void FibonacciNumber()
        {
            Console.WriteLine("Enter a number here");
            int count =Int32.Parse(Console.ReadLine());

            for (int i = 0; i <= count; i++)
            {
                num3 = num1 + num2;
                Console.WriteLine(" "+num3);
                num1 = num2;
                num2 = num3;
            }

        }
    }
}
