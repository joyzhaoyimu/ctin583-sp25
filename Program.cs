
// See https://aka.ms/new-console-template for more information
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("What is your name?");
            // var name = Console.ReadLine();
            // var currentDate = DateTime.Now;
            // Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d}!");
            // Console.Write($"{Environment.NewLine}Press Enter to exit...");
            // Console.Read();

            //Array
            int[] array1; 
            array1 = new int[3];

            int[] array2 = new int[3];

            array2[0] = 1;
            array2[1] = 2;

            int number2 = 10;
            double doublerNumber = 30.33;
            Boolean status = true;
            string message = "Joy is old";
            int age = 22;

            Console.WriteLine("$array2:{array[0]}");
            Console.Write(number2);
            Console.Write(doublerNumber);
            Console.WriteLine(status);
            Console.WriteLine(message);

            //Displays the values of bouth variables
            Console.WriteLine(message+age);

            //For loop, decrementing
            for (int i = 0; i > iteractionCouint; i --){
                //Repeated code

            }

            //Foreach loops
            Vector3[] targets = {Vector3.Zero, Vector3.One, Vector3.UnitX};
            foreach(Vector3 target in targets){
                // Code specific to each tartget in the targets collection
            }

            //While loops
            while(iterationCount == 4){
                //Code that will repeat until the GameObject is no longer active
            }

            //Do-While Loop
            do {
                // code that will run until something is disabled
            } while(true);
        }
    }
}
