using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayWisePractice.Day2
{
    internal class Task2_Operators
    {
        public static void Run()
        {
            int a = 10, b = 3;

            // Arithmetic
            Console.WriteLine($"a + b = {a + b}");
            Console.WriteLine($"a - b = {a - b}");
            Console.WriteLine($"a * b = {a * b}");
            Console.WriteLine($"a / b = {a / b}");
            Console.WriteLine($"a % b = {a % b}");

            // Relational
            Console.WriteLine($"a == b : {a == b}");
            Console.WriteLine($"a > b  : {a > b}");

            // Logical
            bool x = true, y = false;
            Console.WriteLine($"x && y : {x && y}");
            Console.WriteLine($"x || y : {x || y}");
            Console.WriteLine($"!x     : {!x}");

            // Unary
            int num = 5;
            Console.WriteLine($"num++ = {num++}"); // post-increment
            Console.WriteLine($"++num = {++num}"); // pre-increment

            // Ternary
            int marks = 75;
            string result = (marks >= 40) ? "Pass" : "Fail";
            Console.WriteLine($"Marks: {marks}, Result: {result}");
        }
    }
}
