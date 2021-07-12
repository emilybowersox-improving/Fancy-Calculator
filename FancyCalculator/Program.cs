using System;

namespace FancyCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");

            string userInput1 = "";
            string userInput2 = "";
            decimal number1 = 0;
            decimal number2 = 0;
            decimal results = 0;

            userInput1 = Console.ReadLine();

            Console.WriteLine("Enter a second number");

            userInput2 = Console.ReadLine();

            number1 = Convert.ToDecimal(userInput1);
            number2 = Convert.ToDecimal(userInput2);

            results = number1 + number2;

            Console.WriteLine("Your result is " + results);
            Console.ReadLine();


        }
    }
}
