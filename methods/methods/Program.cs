using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********Question2*********");
            Console.Write("Please enter a distance in miles: ");
            double input = double.Parse(Console.ReadLine());





            {
                Console.WriteLine("******QUS3******");
                    Console.Write("Please enter the radius of the circle: ");
                double input = double.Parse(Console.ReadLine());
                Circumference(double.Parse(Console.ReadLine()));
                Console.WriteLine("The circumference of a circle with a radius of " + input + " is " + Math.Round(circum
                Console.WriteLine("The area of a circle with a radius of " + input + " is " + Math.Round(Area(input)));
            }
             double Circumference(double rad)
            {
                Console.WriteLine("**********QUS4*******");
                Console.Write("Please enter a number from 1 - 7: ");
                Console.WriteLine("\nThat number corrresponds  to the day " + Day(int.Parse(Console.ReadLine())));
            } 
                static string Day(int num)
                string[] day = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "saturday", "Sunday" };
            return day[num - 1];

              }
    }
}
