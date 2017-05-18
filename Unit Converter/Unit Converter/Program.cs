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
            //1KM = 0.621371 miles
            Console.WriteLine("***Unit Converter 1.0***");
            Start:
            Console.WriteLine("\n****Lengths****");
            Console.WriteLine("Press 1 To convert from Kilometers to Inches "); //asking for user input
            Console.WriteLine("Press 2 To convert from Meters to Inches ");
            Console.WriteLine("Press 3 To convert from Centimeters to Inches ");
            Console.WriteLine("Press 4 To convert from Kilometers to Feet");
            Console.WriteLine("Press 5 To convert from Meters to Feet");
            Console.WriteLine("Press 6 To convert from Centimeters to Feet");
            Console.WriteLine("Press 7 To convert from Kilometers to Miles");
            Console.WriteLine("Press 8 To convert from Meters to Miles");
            Console.WriteLine("Press 9 to Convert from Centimeters to Miles");

            //Console.WriteLine("****Measurements****");
            //Console.WriteLine("****Temperature****");
            //Console.Writeline("****Mass****");

            Console.Write("\n = ");

            string input = Console.ReadLine();

            double km, m, cm, kmF, mF, cmF, kmM, mM, cmM = 0;

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
                case "7":
                    Console.Write("Enter a value in Kilometers: ");
                    kmM = UnitConverter.KmtoMiles(Console.ReadLine());
                    Console.WriteLine("\n Miles = " + kmM);
                    break;
                case "8":
                    Console.Write("Enter a value in Meters: ");
                    mM = UnitConverter.MtoMiles(Console.ReadLine());
                    Console.WriteLine("Miles = " + mM);
                    break;
                case "9":
                    Console.Write("Enter a value in Centimeters: ");
                    cmM = UnitConverter.CMtoMiles(Console.ReadLine());
                    Console.WriteLine("Miles = " + cmM);
                    break;
                default:
                    Console.WriteLine("please select something to convert");
                    break;
            }
            Console.WriteLine("Do you want to continue? \n Press 1 if so, or to exit press 2.");
            Console.Write("= ");

            string input2 = Console.ReadLine();

            if (input2 == "1")
            {
                goto Start;
            }
            else
            {
                System.Environment.Exit(1);
            }
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
        //Miles conversion
        public static double KmtoMiles(string unitKMtoM)
        {
            double kmM = double.Parse(unitKMtoM);

            double miles = (kmM * 0.621371);

            return miles;
        }
        public static double MtoMiles(string unitMtoM)
        {
            double mM = double.Parse(unitMtoM);

            double miles = (mM * (0.621371 / 1000));

            return miles;
        }
        public static double CMtoMiles(string unitCmtoM)
        {
            double cmM = double.Parse(unitCmtoM);

            double miles = (cmM * (0.621371 / 100000));

            return miles;
        }
    }
}
