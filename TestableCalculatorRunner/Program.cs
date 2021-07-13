﻿using System;
using CalculatorCore;

namespace TestableCalculatorRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            // console stuff goes here
            var calculator = new Calculator();

            Console.WriteLine("Fancy Calculator");

            Console.WriteLine("Enter what you would like to see added:");
            string userInput = Console.ReadLine();

            var myResults = calculator.Evaluate(userInput);

            Console.WriteLine(myResults.Result);
        }
    }
}