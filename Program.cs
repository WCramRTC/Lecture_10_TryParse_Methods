using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_10_TryParse_Methods
{
    internal class Program
    {
        static int number1 = 0;
        static void Main(string[] args)
        {
            //double TenDivTwo = Divide(10, 2);
            //double sum = Add(30, 25);

            //double divideOurResults = Divide(TenDivTwo, sum);

            int factorialSomething = Factorial(5, 5);

            Console.WriteLine(factorialSomething);

        

            Console.ReadKey();
        } // Main

        // MethodBlock

        // Return - Types
        // void = no return type

        public static bool IsEven(int userNumber)
        {

            if(userNumber % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

            
        }

        public static int Factorial(int number, int count)
        {
            int total = number;
            while(count > 0)
            {
                total += total - count;
                count--;
            }

            return total;

        }

        public static double Add(double num1, double num2)
        {
            double sum = num1 + num2;
            return sum;
        }

        public static double Divide(double number1, double number2)
        {
            double divide = number1 / number2;
            // Return keyword
            return divide;
        }

        // Parameters
        //// num1 and num2 are paremeters with no values
        //public static void DisplayThisResult(int num1, int num2, string myName)
        //{
        //    int sum = num1 + num2;

        //    Console.WriteLine($"{myName} says the result of {num1} + {num2} = {sum} ");
        //}

        public static void DivideTwoNumbers(double number1, double number2)
        {
            double divide = number1 / number2;

            Console.WriteLine(divide);
        }

        public static void AddTwoNumbers(int number1, int number2 )
        {
            int sum = number1 + number2;

            Console.WriteLine(sum);
        }

        public static void AddTenPlusTwenty()
        {
            int number1 = 20;
            int number2 = 20;
            int sum = number1 + number2;

            Console.WriteLine(sum);
        }

        static int counter = 40;
        public static void IncrementCount()
        {
            counter++;
            Console.WriteLine(counter);
        }

        public static void TryParseExample()
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

            if (correctInput)
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
        }
    }
}
