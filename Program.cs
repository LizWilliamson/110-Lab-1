using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Hello World!");*/
            new Program(); //creating an instance
        }

        /*Constructor of the class (executed automatically when an instance is created)
        Rules:
        - MUST have the same name as class
        - Is the only method that DOES NOT contain a return type */

        public Program()
        {
            Console.WriteLine("My First DotNet App");
        }

    

        /*Method (funtion)
        - access level (optional, default is private ex. public, private)
        - return type (always return a value of that type ex void returns nothing)
        - Name
        - parameters (type name, type name) 
        - Data types (int, float (use f at end) decimal (use m at end), boolean (true/false yes/no), string) */

        void Test(){
            int age = 99;
            float gravity = 9.8f;
            decimal money = 12.99m;
            bool isThisCrazy = true;
            string text = "This is a string";

            System.Console.WriteLine("This is my name: Liz");

            if(money < 50){
                System.Console.WriteLine("It's cheap");
            }
            else{
                System.Console.WriteLine("It's expensive");
            }

            for(int i=0; i < 9; i++){
                System.Console.WriteLine("Iteration: " + i);
            }
        }

        public int SayHello()
        {
            Console.WriteLine("I'm a method");

            bool isRainny = false;

            if(isRainny)
            {
                return 21;
            }
            else
            {
                return 6;
            }

        }
    }
}
