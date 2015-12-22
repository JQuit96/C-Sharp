using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Author: Julian D. Quitian
Date: 12/22/2015
*/

/// <summary>
/// Basic unit converter program. For added complexity, loop could be added to allow for program re-run and exit with key 'q' only by using Environment.Exit()
/// </summary>
namespace Unit_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            char selection;
            bool endFlag;

            
            Console.WriteLine("{0,23}{1}", "Unit Converter\n",
                                      "------------------------------");
            Console.WriteLine("[1]Fahrenheit <-> Celsius\n" +
                              "[2]Inches     <-> Centimeters\n" +
                              "[3]Pounds     <-> Kilograms\n" +
                              "[4]Gallon     <-> Liter\n" +
                              "[5]Radians    <-> Degrees\n");
            Console.Write("Selection: ");

            endFlag = true;
            do
            {
                selection = Console.ReadKey().KeyChar;
                Console.WriteLine();
                switch (selection)
                {
                    case '1':
                        {
                            GetTemp();          //Option 1
                            break;
                        }
                    case '2':
                        {
                            GetLength();        //Option 2
                            break;
                        }
                    case '3':
                        {
                            GetWeight();        //Option 3
                            break;
                        }
                    case '4':
                        {
                            GetVolume();        //Option 4
                            break;
                        }
                    case '5':
                        {
                            GetAngle();         //Option 5
                            break;
                        }
                    default:
                        {
                            endFlag = false;
                            Console.Write("Enter valid selection: ");
                            break;
                        }
                }
            } while (endFlag == false);
        }
        /// <summary>
        /// Option 1. Prints the conversion to the screen. Uses conversion methods FahrenheitToCelsius(degrees) and CelsiusToFahrenheit(degrees)
        /// </summary>
        static void GetTemp()
        {
            char selection;
            bool endFlag;
            double degrees;
            string degreesString;


            do
            {
                endFlag = true;

                Console.WriteLine("\nTemperature:\n" +
                  "[1]Fahrenheit to Celsius\n" +
                  "[2]Celsius to Fahrenheit\n");
                Console.Write("Selection: ");
                selection = Console.ReadKey().KeyChar;

                switch (selection)
                {
                    case '1':
                        {
                            Console.Write("\nEnter degrees in Fahrenheit: ");
                            degreesString = Console.ReadLine();
                            while (double.TryParse(degreesString, out degrees) == false)
                            {
                                Console.WriteLine("\nPlease enter valid degrees: ");
                                degreesString = Console.ReadLine();
                            }
                            degrees = double.Parse(degreesString);
                            Console.WriteLine("\n{0:F2} degrees Fahrenheit equals {1:F2} degrees Celsius", degrees, FahrenheitToCelsius(degrees));
                            break;
                        }
                    case '2':
                        {
                            Console.Write("\nEnter degrees in Celsius: ");
                            degreesString = Console.ReadLine();
                            while (double.TryParse(degreesString, out degrees) == false)
                            {
                                Console.WriteLine("\nPlease enter valid degrees: ");
                                degreesString = Console.ReadLine();
                            }
                            degrees = double.Parse(degreesString);
                            Console.WriteLine("\n{0:F2} degrees Celsius equals {1:F2} degrees Fahrenheit", degrees, CelsiusToFahrenheit(degrees));
                            break;
                        }
                    default:
                        {
                            endFlag = false;
                            break;
                        }
                }
            } while (endFlag == false);
        }
        /// <summary>
        /// Temperature conversion method
        /// </summary>
        /// <param name="fahr"></param>
        /// <returns>Converted degrees in celsius</returns>
        static double FahrenheitToCelsius(double fahr)
        {
            double celsius = (fahr - 32) * (5.0 / 9.0);
            return celsius;
        }
        /// <summary>
        /// Temperature conversion method
        /// </summary>
        /// <param name="celsius"></param>
        /// <returns>Converted degrees in fahrenheit</returns>
        static double CelsiusToFahrenheit(double celsius)
        {
            double fahr = celsius * (9.0 / 5.0) + 32;
            return fahr;
        }

        /// <summary>
        /// Option 2. Prints the conversion to the screen. Uses conversion methods InchesToCentimeters(length) and CentimetersToInches(length)
        /// </summary>
        static void GetLength()
        {
            char selection;
            bool endFlag;
            double length;
            string lengthString;


            do
            {
                endFlag = true;

                Console.WriteLine("\nLength:\n" +
                  "[1]Inches to Centimeters\n" +
                  "[2]Centimeters to Inches\n");
                Console.Write("Selection: ");
                selection = Console.ReadKey().KeyChar;

                switch (selection)
                {
                    case '1':
                        {
                            Console.Write("\nEnter length in inches: ");
                            lengthString = Console.ReadLine();
                            while (double.TryParse(lengthString, out length) == false)
                            {
                                Console.WriteLine("\nPlease enter valid length: ");
                                lengthString = Console.ReadLine();
                            }
                            length = double.Parse(lengthString);
                            Console.WriteLine("\n{0:F2} inches equals {1:F2} centimeters", length, InchesToCentimeters(length));
                            break;
                        }
                    case '2':
                        {
                            Console.Write("\nEnter length in centimeters: ");
                            lengthString = Console.ReadLine();
                            while (double.TryParse(lengthString, out length) == false)
                            {
                                Console.WriteLine("\nPlease enter valid length: ");
                                lengthString = Console.ReadLine();
                            }
                            length = double.Parse(lengthString);
                            Console.WriteLine("\n{0:F2} centimeters equals {1:F2} inches", length, CentimetersToInches(length));
                            break;
                        }
                    default:
                        {
                            endFlag = false;
                            break;
                        }
                }
            } while (endFlag == false);
        }
        /// <summary>
        /// Length conversion method
        /// </summary>
        /// <param name="inches"></param>
        /// <returns>Converted length in centimeters</returns>
        static double InchesToCentimeters(double inches)
        {
            double centimeters = inches * 2.54;
            return centimeters;
        }
        /// <summary>
        /// Length conversion method
        /// </summary>
        /// <param name="centimeters"></param>
        /// <returns>Converted length in inches</returns>
        static double CentimetersToInches(double centimeters)
        {
            double inches = centimeters / 2.54;
            return inches;
        }

        /// <summary>
        /// Option 3. Prints the conversion to the screen. Uses conversion methods PoundsToKilograms(weight) and KilogramsToPounds(weight)
        /// </summary>
        static void GetWeight()
        {
            char selection;
            bool endFlag;
            double weight;
            string weightString;


            do
            {
                endFlag = true;

                Console.WriteLine("\nWeight:\n" +
                  "[1]Pounds to Kilograms\n" +
                  "[2]Kilograms to Pounds\n");
                Console.Write("Selection: ");
                selection = Console.ReadKey().KeyChar;

                switch (selection)
                {
                    case '1':
                        {
                            Console.Write("\nEnter weight in pounds: ");
                            weightString = Console.ReadLine();
                            while (double.TryParse(weightString, out weight) == false)
                            {
                                Console.WriteLine("\nPlease enter valid weight: ");
                                weightString = Console.ReadLine();
                            }
                            weight = double.Parse(weightString);
                            Console.WriteLine("\n{0:F2} pounds equals {1:F2} kilograms", weight, PoundsToKilograms(weight));
                            break;
                        }
                    case '2':
                        {
                            Console.Write("\nEnter weight in kilograms: ");
                            weightString = Console.ReadLine();
                            while (double.TryParse(weightString, out weight) == false)
                            {
                                Console.WriteLine("\nPlease enter valid weight: ");
                                weightString = Console.ReadLine();
                            }
                            weight = double.Parse(weightString);
                            Console.WriteLine("\n{0:F2} kilograms equals {1:F2} pounds", weight, KilogramsToPounds(weight));
                            break;
                        }
                    default:
                        {
                            endFlag = false;
                            break;
                        }
                }
            } while (endFlag == false);
        }
        /// <summary>
        /// Weight conversion method
        /// </summary>
        /// <param name="pounds"></param>
        /// <returns>Converted weight in kilograms</returns>
        static double PoundsToKilograms(double pounds)
        {
            double kilograms = pounds * 0.45359237;
            return kilograms;
        }
        /// <summary>
        /// Weight conversion method
        /// </summary>
        /// <param name="kilograms"></param>
        /// <returns>Converted weight in pounds</returns>
        static double KilogramsToPounds(double kilograms)
        {
            double pounds = kilograms / 0.45359237;
            return pounds;
        }

        /// <summary>
        /// Option 4. Prints the conversion to the screen. Uses conversion methods GallonsToLiters(volume) and LitersToGallons(volume)
        /// </summary>
        static void GetVolume()
        {
            char selection;
            bool endFlag;
            double volume;
            string volumeString;


            do
            {
                endFlag = true;

                Console.WriteLine("\nVolume:\n" +
                  "[1]Gallons to Liters\n" +
                  "[2]Liters to Gallons\n");
                Console.Write("Selection: ");
                selection = Console.ReadKey().KeyChar;

                switch (selection)
                {
                    case '1':
                        {
                            Console.Write("\nEnter volume in gallons: ");
                            volumeString = Console.ReadLine();
                            while (double.TryParse(volumeString, out volume) == false)
                            {
                                Console.WriteLine("\nPlease enter valid volume: ");
                                volumeString = Console.ReadLine();
                            }
                            volume = double.Parse(volumeString);
                            Console.WriteLine("\n{0:F2} gallons equals {1:F2} liters", volume, GallonsToLiters(volume));
                            break;
                        }
                    case '2':
                        {
                            Console.Write("\nEnter volume in liters: ");
                            volumeString = Console.ReadLine();
                            while (double.TryParse(volumeString, out volume) == false)
                            {
                                Console.WriteLine("\nPlease enter valid volume: ");
                                volumeString = Console.ReadLine();
                            }
                            volume = double.Parse(volumeString);
                            Console.WriteLine("\n{0:F2} liters equals {1:F2} gallons", volume, LitersToGallons(volume));
                            break;
                        }
                    default:
                        {
                            endFlag = false;
                            break;
                        }
                }
            } while (endFlag == false);
        }
        /// <summary>
        /// Volume conversion method
        /// </summary>
        /// <param name="gallons"></param>
        /// <returns>Converted volume in liters</returns>
        static double GallonsToLiters(double gallons)
        {
            double liters = gallons * 3.78541178;
            return liters;
        }
        /// <summary>
        /// Volume conversion method
        /// </summary>
        /// <param name="liters"></param>
        /// <returns>Converted volume in gallons</returns>
        static double LitersToGallons(double liters)
        {
            double gallons = liters / 3.78541178;
            return gallons;
        }

        /// <summary>
        /// Option 5. Prints the conversion to the screen. Uses conversion methods RadiansToDegrees(angle) and DegreesToRadians(angle)
        /// </summary>
        static void GetAngle()
        {
            char selection;
            bool endFlag;
            double angle;
            string angleString;


            do
            {
                endFlag = true;

                Console.WriteLine("\nAngle:\n" +
                  "[1]Radians to Degrees\n" +
                  "[2]Degrees to Radians\n");
                Console.Write("Selection: ");
                selection = Console.ReadKey().KeyChar;

                switch (selection)
                {
                    case '1':
                        {
                            Console.Write("\nEnter angle in radians: ");
                            angleString = Console.ReadLine();
                            while (double.TryParse(angleString, out angle) == false)
                            {
                                Console.WriteLine("\nPlease enter valid angle: ");
                                angleString = Console.ReadLine();
                            }
                            angle = double.Parse(angleString);
                            Console.WriteLine("\n{0:F2} radians equals {1:F2} degrees", angle, RadiansToDegrees(angle));
                            break;
                        }
                    case '2':
                        {
                            Console.Write("\nEnter angle in degrees: ");
                            angleString = Console.ReadLine();
                            while (double.TryParse(angleString, out angle) == false)
                            {
                                Console.WriteLine("\nPlease enter valid angle: ");
                                angleString = Console.ReadLine();
                            }
                            angle = double.Parse(angleString);
                            Console.WriteLine("\n{0:F2} degrees equals {1:F2} radians", angle, DegreesToRadians(angle));
                            break;
                        }
                    default:
                        {
                            endFlag = false;
                            break;
                        }
                }
            } while (endFlag == false);
        }
        /// <summary>
        /// Angle conversion method
        /// </summary>
        /// <param name="radians"></param>
        /// <returns>Converted angle in degrees</returns>
        static double RadiansToDegrees(double radians)
        {
            double degrees = radians * (180 / Math.PI);
            return degrees;
        }
        /// <summary>
        /// Angle conversion method
        /// </summary>
        /// <param name="degrees"></param>
        /// <returns>Converted angle in radians</returns>
        static double DegreesToRadians(double degrees)
        {
            double radians = degrees * (Math.PI / 180);
            return radians;
        }
    }
}
