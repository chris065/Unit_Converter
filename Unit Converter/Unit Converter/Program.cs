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
            //1KM = 39370.1 inches
            //1KM = 3280.84 foot
            Console.WriteLine("***Unit Converter 1.0***");
            Console.ReadLine();

            Console.WriteLine("Press 1 To convert from Kilometers to Inches "); //asking for user input
            Console.WriteLine("Press 2 To convert from meters to Inches ");
            Console.WriteLine("Press 3 To convert from centimeters to Inches ");
            Console.WriteLine("Press 4 To convert from Kilometers to feet");
            Console.WriteLine("Press 5 To convert from meters to feet");
            Console.WriteLine("Press 6 To convert from centimeters to feet");

            Console.Write("\n = ");

            string input = Console.ReadLine();

            double km, m, cm, kmF, mF, cmF = 0;

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

                case "4":
                    Console.Write("Enter a value in Kilometers: ");
                    kmF = UnitConverter.KmtoFeet(Console.ReadLine());
                    Console.WriteLine("\nFeet = " + kmF);
                    Console.ReadLine();
                    break;
                case "5":
                    Console.Write("Enter a value in Meters: ");
                    mF = UnitConverter.MtoFeet(Console.ReadLine());
                    Console.WriteLine("\nFeet = " + mF);
                    Console.ReadLine();
                    break;
                case "6":
                    Console.Write("Enter a value in Centimeters: ");
                    cmF = UnitConverter.CmtoFeet(Console.ReadLine());
                    Console.WriteLine("\nFeet = " + cmF);
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

        //inch conversion
        public static double KmToInches(string unitKilometer)
        {
            double kilometer = double.Parse(unitKilometer);

            double inches = (kilometer * 39370.1);
          
            return inches;
        }
        public static double MToInches(string unitMeter)
        {
            double meter = double.Parse(unitMeter);

            double inches = (meter * (39370.1 / 1000));
                  
            return inches;
        }
        public static double CmToInches(string unitCentimeter)
        {
            double centimeter = double.Parse(unitCentimeter);

            double inches = (centimeter * (39370.1 / 100000));

            return inches;
        }
        //Feet conversion
        public static double KmtoFeet(string unitKiloF)
        {
            double kmF = double.Parse(unitKiloF);

            double feet = (kmF * 3280.84);

            return feet;
        }
        public static double MtoFeet(string unitMF)
        {
            double mF = double.Parse(unitMF);

            double feet = (mF * (3280.84 / 1000));

            return feet;
        }
        public static double CmtoFeet(string unitCMF)
        {
            double cmF = double.Parse(unitCMF);

            double feet = (cmF * (3280.84 / 100000));

            return feet;
        }
    }
}
