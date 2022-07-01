using System;
using InterestClassLibrary;
using InterestClassLibrary.exceptions;
using static System.Console;
using Math = InterestClassLibrary.Math;

namespace CalculatorConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double principle, time, rate;
            WriteLine("Welcome to Interest Calculator ");
            try
            {
                WriteLine("Enter principle amount");
                principle = ValidateInput("PRINCIPLE", ReadLine());

                WriteLine("Enter time in year");
                time = ValidateInput("TIME", ReadLine());

                WriteLine("Enter rate ");
                rate = ValidateInput("RATE", ReadLine());
            }
            catch (InvalidInputException ex)
            {
                WriteLine(ex.Message);
                return;
            }
            //Simple Interest

            var simpleInterest = new SimpleInterest(new Math());
            var si = simpleInterest.Interest(principle, time, rate);
            WriteLine(si);


            // Compound Interest
            var compoundInterest = new CompoundInterest(new Math());
            var ci = compoundInterest.Interest(principle, time, rate);
            WriteLine(ci);

            Read();
        }

        private static double ValidateInput(string type, string input)
        {
            if (string.IsNullOrEmpty(input)) GenerateError(type);
            try
            {
                return Convert.ToDouble(input);
            }
            catch (FormatException)
            {
                GenerateError(type);
            }

            return 0;
        }

        private static void GenerateError(string type)
        {
            switch (type)
            {
                case "PRINCIPLE":
                    throw new InvalidInputException("Invalid Principle Amount Passed");
                case "TIME":
                    throw new InvalidInputException("Invalid Time Passed");
                case "RATE":
                    throw new InvalidInputException("Invalid Rate Passed");
            }
        }
    }
}