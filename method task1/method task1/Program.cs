using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Title*/
            Console.WriteLine("********Task1********\n");
            /*obtain the height from the user*/
            Console.Write("Please enter your height in meters: ");
            double h = double.Parse(Console.ReadLine());
            /*obtain the weight from the user*/
            Console.Write("Please enter your weight in kg's: ");
            double w = double.Parse(Console.ReadLine());

            /*Display the result*/
            Console.WriteLine("Your BMI is: " + BMI(w, h));
        }
        static double BMI(double w, double h)                                                                                                       
        {
        return Math.Round(w/(h*h),1);
        }
        /******** Task 2 Methods *********/
        static void Task2(double bmi)
        {
            if (bmi >= 30)
                Console.WriteLine("Your fat bro...");
            else if (bmi >= 25 && bmi < 30)
                Console.WriteLine("You need to loose some weight...");
            else if (bmi >= 18.5 && bmi < 25)
                Console.WriteLine("oooosh...");
            else
                Console.WriteLine("You to skinny...");
        }
    }
}
