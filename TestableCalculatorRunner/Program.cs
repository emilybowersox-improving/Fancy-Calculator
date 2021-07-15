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
                var showHistory = calculator.ShowHistory();

                if (userInput == "history")
                {
                    foreach (EvaluationResult element in showHistory)
                    {
                        Console.WriteLine($"{element.Equation}, {element.Result}");
                  
                    }
                  
                }
                else if (myResults.Result != 0)
                {
                    Console.WriteLine(myResults.Result);
                }
                else if (userInput == "exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine(myResults.ErrorMessage);
                }
            } while (userInput != "exit");

        


        }
    }
}
