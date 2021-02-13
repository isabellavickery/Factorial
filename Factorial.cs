using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Double i, f = 1, number;
            Console.WriteLine("Enter any Number: ");
            string v;
            v = Console.ReadLine();
            if (Double.TryParse(v, out number))
            {

                if (number > 30)
                {
                    Console.WriteLine("Input is out of bounds and invalid");
                }
                else
                {
                    for (i = 1; i <= number; i++)
                    {
                        f = f * i;
                    }
                    Console.WriteLine("Factorial of " + number + " is: " + f);

                }
            }

            else
            {
                Console.WriteLine("Input is not a number, and is invalid. Please try again");
            }

            
        }
    }
}
