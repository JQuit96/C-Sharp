using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Calculator program. Should really be better.
/// </summary>
namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool end = false;
            double result = 0;

            Greeting();
            do
            {
                result = calculate();
                Console.WriteLine("\nThe answer is {0}\n", result);

                end = getEndFlag();
            } while (end == false);

        }

        /// <summary>
        /// Intro Greeting
        /// </summary>
        static void Greeting()
        {
            string greeting = "Welcome to CalcYouLater! Your non-graphic yet highly efficient accounting tool!";
            Console.WriteLine(greeting);
        }

        /// <summary>
        /// Controlling calculator method.
        /// </summary>
        /// <returns>Result after calculation</returns>
        static double calculate()
        {
            double first, second;
            double result = -1;
            int signSelection;

            Console.WriteLine("\nInput first value: ");
            first = char.GetNumericValue(Console.ReadKey().KeyChar);

            Console.WriteLine("\nInput second value: ");
            second = char.GetNumericValue(Console.ReadKey().KeyChar);

            Console.WriteLine("\nSelect Operator:");
            Console.WriteLine("[1] +\n[2] -\n[3] *\n[4]/\n");
            signSelection = (int)char.GetNumericValue(Console.ReadKey().KeyChar);

            switch (signSelection)
            {
                case 1:
                    result = first + second;
                    break;
                case 2:
                    result = first - second;
                    break;
                case 3:
                    result = first * second;
                    break;
                case 4:
                    result = first / second;
                    break;
            }
            return result;
        }
        static bool getEndFlag()
        {
            bool end;
            Console.WriteLine("Continue? [y/n]: ");

            if (Console.ReadKey().KeyChar.Equals('y'))
            {
                end = false;
            }
            else
                end = true;
            return end;
        }
    }
}
