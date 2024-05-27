using System;

namespace TemperatureConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string userResponse = "";
            int temperature;
            double conversion1;
            double conversion2;
            double conversion3;
            double conversion4;
            bool exitProgram = false;

            do
            {
                Console.WriteLine("Please chose which conversion you'll like to use:");
                Console.WriteLine("1) Convert Celsius to Farenheit.");
                Console.WriteLine("2) Convert Farenheit to Celsius.");
                Console.WriteLine("3) Convert Celsius to Kelvin");
                Console.WriteLine("4) Convert Farenheit to Kelvin");
                Console.WriteLine("X) Exit Program.");
                userResponse = Console.ReadLine();
                userResponse = userResponse.ToUpper();
                userResponse = userResponse.Trim();
                switch (userResponse)
                {
                    case "1":
                        Console.WriteLine("What is the temperature you want to convert?");
                        temperature = int.Parse(Console.ReadLine());
                        conversion1 = (temperature * 9 / 5) + 32;
                        Console.WriteLine("We convert " + temperature + " degrees Celsius to " + conversion1 + " derees Farenheit.");
                        break;
                    case "2":
                        Console.WriteLine("What is the temperature you want to convert?");
                        temperature = int.Parse(Console.ReadLine());
                        conversion2 = (temperature - 32) * 5 / 9;
                        Console.WriteLine("We convert " + temperature + " degrees Farenheit to " + conversion2 + " degrees Celsius.");
                        break;
                    case "3":
                        Console.WriteLine("What is the temperature you want to convert?");
                        temperature = int.Parse(Console.ReadLine());
                        conversion3 = temperature + 273.15;
                        Console.WriteLine("We convert " + temperature + " degrees Celsius to " + conversion3 + " degrees Kelvin.");
                        break;
                    case "4":
                        Console.WriteLine("What is the temperature you want to convert?");
                        temperature = int.Parse(Console.ReadLine());
                        conversion4 = temperature - 273.15;
                        Console.WriteLine("We convert " + temperature + " degrees Farenheit to " + conversion4 + " degrees Kelvin.");
                        break;
                    case "X":
                        exitProgram = true;
                        break;
                    default:
                        Console.WriteLine("You did not enter a valid response, please enter 1 or 2");
                        break;
                }

                } while (!exitProgram) ;
            Console.ReadLine();

            }

        }
    }

