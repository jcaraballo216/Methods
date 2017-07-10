using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Methods are a tool for us to create reusable pieces of code.

            //Methods are a way of us collecting a series of instuctions and the call them..
            //when we need them.

            //Methods are always part of a class. Methods are always children classes.
            //This means a method will never be  created inside another method or member of the class...
            //However, methods are frequently called inside of another class or method.
            Console.WriteLine("Hello. Please enter the first number to be added.");
            int numberOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Hello. Please enter the second number to be added.");
            int numberTwo = int.Parse(Console.ReadLine());


            int answer = Add(numberOne, numberTwo);
            Console.WriteLine("The sum of your two numbers are " + answer);

        }
        //Method Header
        //Access Modifier - Return Type - Method Name (in Pascal Case) - Parantheses (sometimes with parameters)
        public static int Add(int firstnumber, int secondNumber)     //example
        {
            //Method Body
            //A complete method header and body - is called a method declaration

            int sum = firstnumber + secondNumber;

            return sum;
            //The "return" keyword takes whatever calue is determined by using this method...
            //and sends that value back to where I call my method.
        }
        //If you have a method that does not have a return value, you would use the keyword "void"...
        //When we have a "void" return type we dont need to use the keyword "return".
    }
}
