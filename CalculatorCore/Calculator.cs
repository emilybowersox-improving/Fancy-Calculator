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
                        return new EvaluationResult { ErrorMessage = $"{inputs[1]} is not a valid operator- try +, -, *, or /" };
                }

                return new EvaluationResult { Result = results };
            }

            else
            {
                return new EvaluationResult { ErrorMessage = $"{fullInput} is not a valid expression" };

    

            }






        }
        }
    }
