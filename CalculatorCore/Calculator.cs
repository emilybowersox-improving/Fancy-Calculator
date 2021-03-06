using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace CalculatorCore
{
    public class Calculator
    {
        private decimal savedNumber = 0m;
        private decimal number1 = 0m;
        private decimal number2 = 0m;
        private List<EvaluationResult> _calcHistory = new List<EvaluationResult>();


        public EvaluationResult Evaluate(string fullInput)
        {
            decimal results;
            char[] delimiterChars = { ' ' };
            string[] inputs = new string[3];
            string[] contInput = new string[2];


            //for continued operations
            contInput = fullInput.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
            if (contInput.Length == 2)
            {
                if (decimal.TryParse(contInput[1], out number2) == false)
                {
                    return new EvaluationResult { ErrorMessage = $"{contInput[1]} is not a valid continuation" };
                } else   {
                    string i = contInput[0];

                    switch (i)
                    {
                        case "+":
                            results = savedNumber + number2;
                            break;
                        case "-":
                            results = savedNumber - number2;
                            break;
                        case "*":
                            results = savedNumber * number2;
                            break;
                        case "/":
                            results = savedNumber / number2;
                            break;
                        default:
                            /*    throw new NotImplementedException("Not a valid operator");*/
                            return new EvaluationResult { ErrorMessage = $"{contInput[0]} is not a valid continuing operator- try +, -, *, or /" };
                    }
                    savedNumber = results;

                    EvaluationResult currentResult = new EvaluationResult { Result = results, Equation = fullInput };
                    AddHistory(currentResult);
                    /*      History().Add(new EvaluationResult { Result = results, Equation = fullInput });*/
                    /* return new EvaluationResult { Result = results, Equation = fullInput };*/
                    return currentResult;
                }
            }



            inputs = fullInput.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);

            if (inputs.Length != 3 && inputs.Length != 2)
            {
                return new EvaluationResult { ErrorMessage = $"'{fullInput}' is not valid. Your first input must be be in the form '3 + 5' and subsequent inputs can be in either the form '3 + 5' or '+ 5'" };
            }

            if (decimal.TryParse(inputs[0], out number1) == false)
            {
                return new EvaluationResult { ErrorMessage = $"{inputs[0]} is not a valid number" };
            }

            if (decimal.TryParse(inputs[2], out number2) == false)
            {
                return new EvaluationResult { ErrorMessage = $"{inputs[2]} is not a valid number" };
            }


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
                        /*    throw new NotImplementedException("Not a valid operator");*/
                        return new EvaluationResult { ErrorMessage = $"{inputs[1]} is not a valid operator- try +, -, *, or /" };
                }

                savedNumber = results;
                EvaluationResult currentResult = new EvaluationResult{Result = results, Equation = fullInput};
                AddHistory(currentResult);

                return new EvaluationResult { Result = results, Equation = fullInput };
            }
            else
            {
                return new EvaluationResult { ErrorMessage = $"{fullInput} is not a valid expression" };
            }
        }


        public List<EvaluationResult> AddHistory(EvaluationResult newResult)
        {
            _calcHistory.Add(newResult);
            return _calcHistory;

        }


        public List<EvaluationResult> DisplayHistory()
        {
            return _calcHistory;
        }




    }
}
