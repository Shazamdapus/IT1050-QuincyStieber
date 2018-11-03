using System;

namespace LabW4QuincyStieber
{
    class LabW4
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int sum;

            Console.WriteLine("Enter the first integer: ");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second integer: ");
            number2 = int.Parse(Console.ReadLine());

            sum = number1 + number2;

            Console.WriteLine($"The sum of the integers is: {sum}");

            {
                int x = 56;
                int y = 64;
                int z = 73;

                sum = (x + y) * (z + 10);

                Console.WriteLine($"The answer to the equation is: {sum}");
            }
            {
                Console.WriteLine("Hello\tWorld!");

                Console.WriteLine("Hello\nWorld!");

                Console.WriteLine("\"Hello World!\"");

                Console.WriteLine("Hello/World!");
            }
        }
    }

}








