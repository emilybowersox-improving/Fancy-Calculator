using System;
using System.Text.RegularExpressions;

namespace FancyCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fancy Calculator");

            decimal number1 = 0;
            decimal number2 = 0;
            decimal results = 0;

            string fullInput = "";
            char[] delimiterChars = { ' ' };
/*            char[] delimiterChars = { ' ', '+', '-', '*', '/' };*/
            string[] inputs = new string[3];
                
            fullInput.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);

            do
                {
                Console.WriteLine("Enter what you would like to see added:");
                fullInput = Console.ReadLine();
                inputs = fullInput.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);

/*                inputs = Regex.Split(fullInput.Trim(), "(?<=[+*//*-])"); 
                Console.WriteLine(inputs);
                Console.WriteLine(inputs[0]);
                Console.WriteLine(inputs[1]);
                Console.WriteLine(inputs[2]);
                Console.ReadLine();*/

                if (decimal.TryParse(inputs[0], out number1) == true && decimal.TryParse(inputs[2], out number2) == true)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine(fullInput + " is not a valid expression");
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

         /*   results = number1 + number2;*/


            Console.WriteLine("Your result is " + results);
            Console.ReadLine();




        }
    }
}
