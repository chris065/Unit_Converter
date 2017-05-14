using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Converter
{
    class Program
    {
        static void Main()
        {
            //1KM = 39370.1

            Console.WriteLine("***Unit Converter 1.0***");
            Console.ReadLine();

            Console.WriteLine("Press 1 To convert from Kilometers to Inches \n Press 2 to Convert From Meters to Inches \n Press 3 to convert from Centimeters to Inches"); //asking for user input
            Console.Write("= ");

            string input = Console.ReadLine();

            double km, m, cm = 0;

            switch (input) //using switch statement as it is easier to read for other developers and users.
            {
                case "1":
                    Console.Write("Enter a value in kilometers: ");
                    km = UnitConverter.KmToInches(Console.ReadLine());
                    Console.WriteLine("\n Inches = " + km);
                    Console.ReadLine();
                    break;

                case "2":
                    Console.Write("Enter a value in meters: ");
                    m = UnitConverter.KmToInches(Console.ReadLine());
                    Console.WriteLine("\n Inches = " + m);
                    Console.ReadLine();
                    break;

                case "3":
                    Console.Write("Enter a value in centimeters: ");
                    cm = UnitConverter.CmToInches(Console.ReadLine());
                    Console.WriteLine("\n Inches = " + cm);
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("please select something to convert");
                    break;
            }
            Console.WriteLine("Press any key to quit the app...");
            Console.ReadKey();
        }
    }
    public class UnitConverter //class where methods are stored for each conversions
    {
        public static double KmToInches(string unitKilometer)
        {
            double kilometer = double.Parse(unitKilometer);

            double inches = (kilometer * 39370.1);
          
            return inches;
        }
        public static double MToInches(string unitMeter)
        {
            double meter = double.Parse(unitMeter);

            double inches = (meter * (39370 / 1000));
                  
            return inches;
        }
        public static double CmToInches(string unitCentimeter)
        {
            double centimeter = double.Parse(unitCentimeter);

            double inches = (centimeter * (39370 / 100000));

            return inches;
        }
    }
}
