using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Julian D. Quitian
/// 12/25/2015
/// Factorial Finder v1.0.0
/// </summary>
namespace Factorial_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            bool end = true;

            Console.WriteLine("Welcome to Factorial Finder!");

            do
            {
                Console.Write("Enter number for which you'd like to find the factorial: ");
                n = int.Parse(Console.ReadLine());

                Console.WriteLine(n);

                Console.WriteLine("The nth factorial of {0} is {1}\n", n, factorial(n));

                Console.WriteLine("Would you like to restart program? [y/n]");
                if (Console.ReadLine().Equals("y"))
                    end = false;
            } while (end == false);

        }
        public static int getFactorial(int n)
        {
            int i = 1;
            if (n == 0)
                return 1;
            else if(n > 16)
            {
                Console.WriteLine("Number is too big");
                return -1;
            }
            else
                for (int j = n; j > 0; j--)
                {
                    i *= j;
                }
            return i;
        }
    }
}
