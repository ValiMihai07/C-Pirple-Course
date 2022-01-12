using System;

namespace proceduralVSoop
{
    class Program
    {

        //Procedural is here
        
        static void printHello()
        {
            Console.WriteLine("Hello World!");
        }

        static int sum( int a , int b)
        {
            int result = a + b;
            return result;
        }






        static void Main(string[] args)
        {

            /*  Differences:
             *      
             *      -in procedural program is divided in small funciton and in OOP is object and classes 
             *      
             *      -There is no specifer access and in OOP exist public , private ,protected etc
             *      
             *      -in OOP is possible overloading and in procedural no
             *      
             *      -Procedural Programming can be defined as a programming model which is derived from structured programming,
             *      based upon the concept of calling procedure. Procedures, 
             *      also known as routines, subroutines or functions,
             *      simply consist of a series of computational steps to be carried out. 
             *      During a program’s execution, any given procedure might be called at any point,
             *      including by other procedures or itself.
             *     
             *      -Object oriented programming can be defined as a programming model which is based upon the concept of objects.
             *      Objects contain data in the form of attributes and code in the form of methods.
             *      In object oriented programming, computer programs are designed using the concept of objects that interact with real world.
             *      Object oriented programming languages are various but the most popular ones are class-based,
             *      meaning that objects are instances of classes, which also determine their types.
             */

            // In procedural you cand call them easy than in oop
            printHello();
            // In OOP you need to make an object
            OOP test = new OOP();
            test.printHelloWorld();


        }
    }
}
