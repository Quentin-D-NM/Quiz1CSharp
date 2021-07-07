using System;

namespace Quiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "n";

            do
            {
                ForceCalc fc = new ForceCalc();

                Console.WriteLine("Please enter the mass of your first object in kilograms: ");
                fc.Object1 = Double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the mass of your second object in kilograms: ");
                fc.Object2 = Double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the distance between the two objects in meters: ");
                fc.Distance = Double.Parse(Console.ReadLine());

                Console.WriteLine("The gravitational force between the two objects is: {0}", fc.GravitationalForace);



                Console.WriteLine("Would you like to make another Calculation?(Y or n) ");
                answer = Console.ReadLine();
            } while (answer == "y" || answer == "Y");
        }
    }
}
