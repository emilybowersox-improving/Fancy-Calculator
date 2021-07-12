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

            do
                {
                Console.WriteLine("Enter what you would like to see added:");
                fullInput = Console.ReadLine();
                inputs = fullInput.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);


                if (decimal.TryParse(inputs[0], out number1) == true && decimal.TryParse(inputs[2], out number2) == true)
                    {
                        break;
                    }
                    else
                    {
                    if (inputs[1] != "+" || inputs[1] != "-" || inputs[1] != "*" || inputs[1] != "/")
                    {
                        Console.WriteLine(inputs[1] + " is not a valid operator");
                        } else {
                        Console.WriteLine(fullInput + " is not a valid expression");
                    }
                    
                      
                    }
                } while (decimal.TryParse(inputs[0], out number1) == false || decimal.TryParse(inputs[2], out number2) == false);


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
            }

            Console.WriteLine("Your result is " + results);
            Console.ReadLine();

        }
    }
}
