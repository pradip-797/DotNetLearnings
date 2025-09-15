using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DayWisePractice.Day3
{
    internal class Day3_ControlFlow
    {
        public static void Run()
        {
        // Task 1 – Grade System (Input: student marks, Output: Grade(A / B / C / Fail) using if-else.)
                    Console.WriteLine("Enter a Marks");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number >= 90)
            {
                Console.WriteLine("Grade A"); 
            }
             else if (number >= 75)
            {
                Console.WriteLine("Grade B");
            }
            else if (number >= 50)
            {
                Console.WriteLine("Grade C");
            }
            else
            {
                Console.WriteLine("Fail");
            }

            //Task 2 – Role-Based Login Input: user role(Admin/ User / Guest), Output: Message using switch expression.
            Console.WriteLine("Enter role (Admin/User/Guest): ");
            string role = Console.ReadLine();
            string message = role switch
            {
                "Admin" => "Welcome, Admin! You have full access.",
                "User" => "Welcome, User! You have limited access.",
                "Guest" => "Welcome, Guest! You have guest access.",
                _ => "Invalid role. Please enter Admin, User, or Guest."
            };

            Console.WriteLine(message);
        }
    }
}
