using System;

namespace BasicStructure
{
    class Program
    {
        static void Main(string[] args)


        {

            //Task No 1

            //Taking Two integers as input and returning Output
            //Console.WriteLine("Enter Number 1");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter number 2 ");
            //int number2= int.Parse(Console.ReadLine());
            ////By using if else statement
            //if (number1 == number2)
            //{
            //    Console.WriteLine($"Both Entered Numbers {number1} and {number2} are Equal...");
            //}
            //else {
            //    Console.WriteLine($"Nope! The Entered Numbers {number1} and {number2} aren't equal");
            //}




            //Task no 2
            //Console.WriteLine("Enter Number 1");
            //int number1 = int.Parse(Console.ReadLine());

            ////byte using if statement

            //if (number1 % 2 == 0)
            //{
            //    Console.WriteLine($"The entered number {number1} is an even number");
            //}
            //else {
            //    Console.WriteLine($"The entered number {number1} is an odd number");

            //}


            //Task 3
            //positive or negative
            //Console.WriteLine("Enter Number 1");
            //int number1 = int.Parse(Console.ReadLine());
            ////by using if else statement method
            //if (number1 > 0)
            //{
            //    Console.WriteLine($"The entered Number {number1} is positive");
            //}
            //else { 
            //    Console.WriteLine($"The entered Number {number1} is negative");
            //}



            //Task no 4

            //Eligible for vote or not 
            //Console.WriteLine("Note You are only Eligible to vote if you are 18 or + Enter age: ");
            //float age = float.Parse(Console.ReadLine());
            ////by using if else statement method
            //if (age >= 18)
            //{
            //    Console.WriteLine("you are eligible for voting");
            //}
            //else { 
            //    Console.WriteLine("Sorry ! you are not eligible for the voting ");
            //}


            //Task 5
            // take height in centimeters and categorize according to it.

            Console.WriteLine("Enter Height in (cm) : ");
            float userHeight = float.Parse(Console.ReadLine());
            //by using if else statement method

            if (userHeight <= 160)
            {
                Console.WriteLine("you are short");
            }
            else if (userHeight >= 160 && userHeight <= 175)
            {
                Console.WriteLine("you are average only");
            }
            else{
                Console.WriteLine("You are tall");
            }


        }
    }
}