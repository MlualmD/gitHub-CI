<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
<<<<<<< HEAD
    public class Program: Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program performs basic math operation on 2 numbers");
            Console.WriteLine("Please insert the first number");

            double firstNumber = Convert.ToDouble(Console.ReadLine());




            Console.WriteLine("Please insert the second number");
            Console.WriteLine("Please insert the second number");

            double secondNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please select your operation");
            Console.WriteLine("+: for addition");
            Console.WriteLine("-: for subtraction");
            Console.WriteLine("*: for multiplication");
            Console.WriteLine("/: for division");

            var operand = Console.ReadLine();

            if (operand == "+")
            {
                var result = Add(firstNumber, secondNumber);
                Console.WriteLine(result);
            }
            else if (operand == "-")
            {
                var result = Subtract(firstNumber, secondNumber);
                Console.WriteLine(result);
            }
            else if (operand == "*")
            {
                var result = Multiply(firstNumber, secondNumber);
                Console.WriteLine(result);
            }
            else if (operand == "/")
            {
                var result = Divide(firstNumber, secondNumber);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("You have made an invalid selection");
            }
        }  

=======
    public class Program
    {
        static void Main(string[] args)
        {  
        }  

        public int Sum(int a, int b)
        {
            return a + b;
        }
>>>>>>> 35b91023b2bfaa7d87df55c7e5749d2fad9594e5
    }
}
=======
Succeeded
>>>>>>> 131ac0ee7a52d6f2c20b3e6d26a12a7d2f48f1f8
