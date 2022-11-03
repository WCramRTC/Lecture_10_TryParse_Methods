using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_10_TryParse_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TryParse

            //try
            //{
            //    int value = int.Parse("ten");
            //    Console.WriteLine("Print this line");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Your exception was {ex.Message}");
            //}

            Console.Write("Enter a number: ");

            int usersNumber = -1;
            bool correctInput = int.TryParse(Console.ReadLine(), out usersNumber);

            if(correctInput)
            {
                Console.WriteLine(usersNumber * usersNumber);
            }
            else
            {
                Console.WriteLine("That was an invalid input");
            }


            //    int theNumber = 0;
            //bool isANumber = int.TryParse("ten", out theNumber);
            //if(isANumber)
            //{
            //    Console.WriteLine("That was a valid number");

            //}
            //else
            //{
            //    Console.WriteLine("That was an invalid number");
            //}
            //Console.WriteLine($"The value of result {theNumber}");

            //try
            //{
            //    int number = int.Parse("dog");

            //}
            //catch
            //{
            //    Console.WriteLine("Enter a valid number");
            //}

            // Methods

            Console.ReadKey();
        }
    }
}
