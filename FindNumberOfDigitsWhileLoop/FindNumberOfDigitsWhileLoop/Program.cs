using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindNumberOfDigitsWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 15243; int count = 0; int digit = number;
            while(number>0)
            {
                ++count;
                number =  number/ 10;
            }
            Console.WriteLine("Given digit {0} contains {1} digits ", digit, count);
            Console.ReadLine();
        }
    }
}
