using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorCore
{
    public class Calculator
    {
        public EvaluationResult Evaluate(string fullInput)
        {
            decimal number1 = 0m;
            decimal number2 = 0m;
            decimal results;

            char[] delimiterChars = { ' ' };
            string[] inputs = new string[3];




            do
            {
                inputs = fullInput.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);

                if (decimal.TryParse(inputs[0], out number1) == true && decimal.TryParse(inputs[2], out number2) == true)
                {
                    break;
                }
                else
                {
                    //
                    //
                    // i want to print an error message here- not break out of my do-while loop
                    return new EvaluationResult { ErrorMessage = $"'{fullInput}' is not a valid expression" };

           /*         if (inputs[1] != "+" || inputs[1] != "-" || inputs[1] != "*" || inputs[1] != "/")
                    {
                        return new EvaluationResult { ErrorMessage = $"'{inputs[1]}' is not a valid operator" };
                    }
                    else
                    {
                        return new EvaluationResult { ErrorMessage = $"'{fullInput}' is not a valid expression" };
                    }*/

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
                default:
                    throw new NotImplementedException("Not a valid operator");
            }

            return new EvaluationResult { Result = results };
        }
    }
}
