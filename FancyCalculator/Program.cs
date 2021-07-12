using System;

namespace FancyCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fancy Calculator");
     
            string userInput1 = "";
            string userInput2 = "";
            decimal number1 = 0;
            decimal number2 = 0;
            decimal results = 0;

            do
            { 
                Console.WriteLine("Enter a number");
                userInput1 = Console.ReadLine();
                if (decimal.TryParse(userInput1, out number1) == true)
                {
                    break;
                } else
                {
                    Console.WriteLine(userInput1 + " is not a valid number");
                }
            }  while (decimal.TryParse(userInput1, out number1) == false);


            do
            {
                Console.WriteLine("Enter another number");
                userInput2 = Console.ReadLine();
                if (decimal.TryParse(userInput2, out number2) == true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(userInput2 + " is not a valid number");
                }
            }   while (decimal.TryParse(userInput2, out number2) == false);


            results = number1 + number2;

            Console.WriteLine("Your result is " + results);
            Console.ReadLine();


        }
    }
}
