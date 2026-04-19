using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Give the user to eneter the name of the student
            Console.Write("Enter student name: ");
            string studentname = Console.ReadLine();

            double[] marks = new double[3];

            // Give the user to enter 3 marks for the student
            for (int i = 1; i <= 3; i++)
            {
                while (true)
                {
                    Console.Write($"Enter mark for Subject {i}: ");
                    string input = Console.ReadLine();

                    // Check if the user has inserted a valid number or not
                    if (double.TryParse(input, out double mark)) { 
                        marks[i - 1] = mark;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number");
                    }
                }

            }
            double total = marks[0] + marks[1] + marks[2]; // This is used to calculate the total marks that the student have
            double average = total / 3;

            string result;

            if (average >= 50) {
                result = "PASS";
            }
            else
            {
                result = "FAIL";
            }

            string issuedat = DateTime.Now.ToString("dd MMM yyyy HH:mm:ss");

            Console.WriteLine(); // This is a extra line to give sepration between the marks and the students Results
            Console.WriteLine("===== STUDENT RESULTS =====");
            Console.WriteLine($"Student Name: {studentname}");
            Console.WriteLine($"Total Marks: {total}");
            Console.WriteLine($"Average Marks: {average:0.#}"); // The 0 after the average will show one digit after the number and the # is to show only one decimal point
            Console.WriteLine($"Result: {result}");
            Console.WriteLine($"Result Issued at: {issuedat}");
        }
    }
}
