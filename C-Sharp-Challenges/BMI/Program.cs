﻿using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            InputBmi();
            var result = BmiFormula();
            Console.WriteLine(result);
        }

        static void InputBmi()
        {
            Console.WriteLine("Enter your height in cm :");

            var height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your weight in kg:");

            var weight = Convert.ToDouble(Console.ReadLine());
        }

        static double BmiFormula(double weight = 160, double height = 80)
        {
            var bmi = Math.Round(weight / Math.Pow(height / 100, 2), 2);

            if (bmi <= 18.4)
            {
                Console.Write("You are Underweight : ");
                return bmi;
            }

            else if (bmi >= 18.52 && bmi <= 24.9)
            {
                Console.Write("You are Normal : ");
                return bmi;
            }

            else if (bmi >= 25.0 && bmi <= 39.9)
            {
                Console.Write("You are Overweight : ");
                return bmi;
            }

            else
            {
                Console.Write("You are Obese : ");
                return bmi;
            }
        }
    }
}
