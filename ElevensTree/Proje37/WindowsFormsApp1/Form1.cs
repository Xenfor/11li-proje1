﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the operator (+, -, *, /): ");
            char op = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: division by zero");
                        return;
                    }
                    else
                    {
                        result = num1 / num2;
                        break;
                    }
                default:
                    Console.WriteLine("Invalid operator");
                    return;
            }

            Console.WriteLine("Result: " + result);
        }
    }
}