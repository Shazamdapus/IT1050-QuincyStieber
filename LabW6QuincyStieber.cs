using System;

namespace LabW6QuincyStieberIT1050
{
    class Program
    {
        static void Main(string[] args)
         
        {
            int speedLimit = 35;
            int speed = 42;

            if (speed > speedLimit) 
            Console.WriteLine("Slow Down!");

            bool isTrue = true;
            bool isFalse = false;
            bool answer = true; 

            Console.WriteLine("True or False? 101011 is 43 in decimal.");
                   answer = bool.Parse(Console.ReadLine());
            if (answer == true) 
                Console.WriteLine($"That is {isTrue}!");

            else 
            {
                Console.WriteLine($"That is {isFalse}!");
            }

            decimal degF;
            decimal degC;

            Console.WriteLine("Enter the temperature in degress Fahrenheit:");
                degF = decimal.Parse(Console.ReadLine());

            degC = (degF - 32) * 5/9;

            Console.WriteLine($"That is {degC} in Celsius!");

                   if (degF <= 40)
                Console.WriteLine("It sure is cold today.");

            else if (degF >= 90)
            {
                Console.WriteLine("Man oh man is it hot!");
            }

            int i;
            i = 1;

            while (i <= 10)
            {
                Console.WriteLine(i);
                i = i + 1;
            }
            /*
            {

                int i;
                i = 60;

                while (i >= 20)
                {
                    Console.WriteLine(i);
                    i = i - 1;
                }
            }
            {

                int i;
                i = 10;

                while (i <= 20)
                {
                    Console.WriteLine(i);
                    i = i + 1;
                }*/
            }

        }

    }

