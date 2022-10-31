﻿using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcOperations calcOperations = new CalcOperations();
            Console.Clear();
            Console.WriteLine("--------------");
            Console.WriteLine("Calculator Program");
            Console.WriteLine("--------------");
            Console.WriteLine("Enter number : {0}1 - Addition{0}2 - Substraction{0}3 - Multiplication{0}4 - Division", Environment.NewLine);

            var userInput = int.Parse(Console.ReadKey().KeyChar.ToString());
            Console.WriteLine();

            GetUserInput(calcOperations);

            var getOperation = new double[] { calcOperations.Counting(), calcOperations.Subtraction(), calcOperations.Multiplication(), calcOperations.Division() };
            Console.WriteLine(getOperation[userInput - 1]);
            Console.ReadKey();
        }
        static void GetUserInput(CalcOperations calcOperations)
        {
            
            try
            {
                Console.WriteLine("Enter the 1. number: ");
                calcOperations.firstNum = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the 2. number: ");
                calcOperations.secondNum = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please Entered one number between 1 - 4");
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("You can't devide by 0 :( Enter another number !");
            }
        }
    }

    class CalcOperations
    {
        public double firstNum;
        public double secondNum;
        public double result;

        public double Counting()
        {
            result = firstNum + secondNum;
            return result;
        }
        public double Subtraction()
        {
            result = firstNum - secondNum;
            return result;
        }
        public double Multiplication()
        {
            result = firstNum * secondNum;
            return result;
        }
        public double Division()
        {
            result = firstNum / secondNum;
            return result;
        }
    }
}
