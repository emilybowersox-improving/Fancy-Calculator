using System;
using CalculatorCore;

namespace TestableCalculatorRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            // console stuff goes here
            var calculator = new Calculator();

            Console.WriteLine("Fancy Calculator");

            do
            {
                Console.WriteLine("Enter what you would like to see added:");
                userInput = Console.ReadLine();

                var myResults = calculator.Evaluate(userInput);

                if (myResults.Result != 0)
                {
                    Console.WriteLine(myResults.Result);
                }
                else
                {
                    Console.WriteLine(myResults.ErrorMessage);
                }
            } while (userInput != "exit");

        


        }
    }
}
