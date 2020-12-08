using System;

namespace CSharpFundamentals
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Set Speed Limit (km/h):");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Now enter the vehicle's speed (km/h):");
            var vehicleSpeed = Convert.ToInt32(Console.ReadLine());

            if(vehicleSpeed <= speedLimit)
            {
                Console.WriteLine("Legal speed, no action required.");
            }

            else
            {
                const int kmPerDemeritPoints = 5;
                var demeritPoints = (vehicleSpeed - speedLimit) / kmPerDemeritPoints;

                if(demeritPoints >= 12)
                {
                    Console.WriteLine("License Suspended.");
                }

                // This check is to cover infractions between 1km/h and 4km/h

                else if(demeritPoints == 0)
                {
                    demeritPoints++;
                    Console.WriteLine("Demerit Points: " + demeritPoints);
                }
                else
                {
                    Console.WriteLine("Demerit Points: " + demeritPoints);
                }
            }

            

            /*Console.WriteLine("This program will display the higher number between two values.\nInput your first number:");
            var number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input your second number:");
            var number2 = Convert.ToInt32(Console.ReadLine());
       
            if(number1 > number2)
            {
                Console.WriteLine($"The higher number is {number1}");
            }
            else if(number2 > number1)
            {
                Console.WriteLine($"The higher number is {number2}");
            }
            else
            {
                Console.WriteLine("Both numbers are equal");
            }*/

            /*Console.WriteLine("Input a number between 1 and 10:");
            var userInput = Console.ReadLine();
            var userNumber = Convert.ToInt32(userInput);

            if(userNumber >= 0 && userNumber <= 10)
            {
                Console.WriteLine($"The number {userNumber} is valid.");
            }
            else
            {
                Console.WriteLine($"The number {userNumber} is invalid.");
            }*/
        }
    }
}
