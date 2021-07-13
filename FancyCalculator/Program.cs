using System;
using System.Text.RegularExpressions;

namespace FancyCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fancy Calculator");

            decimal number1 = 0m;
            decimal number2 = 0m;
            decimal results = 0m;

            string fullInput = "";
            char[] delimiterChars = { ' ' };
            string[] inputs = new string[3];
            string userContinue = "";
            string userExit = "exit";
         

            do
            {
                Console.WriteLine("Would you like to continue? Type exit to exit, or press enter to continue");
                userContinue = Console.ReadLine();
                Console.WriteLine(userContinue);
                Console.WriteLine(!userContinue.Equals(userExit));

                do
                {
                    Console.WriteLine("Enter what you would like to see added:");
                    fullInput = Console.ReadLine();
                    inputs = fullInput.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);


                    if (decimal.TryParse(inputs[0], out number1) == true && decimal.TryParse(inputs[2], out number2) == true)
                    {
                        string i = inputs[1];

                        switch (i)
                        {
                            case "+":
                                results = number1 + number2;
                                break;
                            case "-":
                                results = number1 - number2;
                                break;
                            case "*":
                                results = number1 * number2;
                                break;
                            case "/":
                                results = number1 / number2;
                                break;
                            default:
                                throw new NotImplementedException("Not a valid operator");
                        }
                        Console.WriteLine("Your result is " + results);
                        break;
                     

                    }
                    else
                    {
                        Console.WriteLine($"'{fullInput} is not a valid expression");


                    }
                } while (decimal.TryParse(inputs[0], out number1) == false || decimal.TryParse(inputs[2], out number2) == false);


                // this while statement is not working --needs to evaluate to true or false
                //this statement is evaluating to false...
            } while (!userContinue.Equals(userExit));



     
         

        }
    }
}
