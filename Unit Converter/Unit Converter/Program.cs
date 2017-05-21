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
            //1KM = 1093.61 yards 
            Console.WriteLine("***Unit Converter 1.0***");

            Start:
            Console.WriteLine("\n****Lengths****");
            Console.WriteLine("Press 1 To convert from Metric to Inches "); //asking for user input

            Console.WriteLine("Press 2 To convert from Metric to Feet");

            Console.WriteLine("Press 3 To convert from Metric to Miles");

            Console.WriteLine("Press 4 to convert from Metric to Yards");

            //Console.WriteLine("****Volume****");
            //Console.WriteLine("****Temperature****");
            //Console.Writeline("****Mass****");

            Console.Write("\n = ");

            string input = Console.ReadLine();

            double km, m, cm, kmF, mF, cmF, kmM, mM, cmM, kmY, mY, cmY = 0;

            switch (input) //using switch statement as it is easier to read for other developers and users.
            {
                case "1":

                    Console.Write("Convert from Kilometers (Press A), Meters (B) or Centimeters (C): ");
                    string selection1 = Console.ReadLine();

                    if (selection1 == "A")
                    {
                        Console.Write("Enter a value in Kilometers: ");

                        km = UnitConverter.KmToInches(Console.ReadLine());

                        Console.WriteLine("\n Inches = " + km);
                    }
                    if (selection1 == "B")
                    {
                        Console.Write("Enter a value in Meters: ");

                        m = UnitConverter.MToInches(Console.ReadLine());

                        Console.WriteLine("\n Inches = " + m);
                    }
                    if (selection1 == "C")
                    {
                        Console.Write("Enter a value in Centimeters: ");

                        cm = UnitConverter.CmToInches(Console.ReadLine());

                        Console.WriteLine("\n Inches = " + cm);
                    }

                    break;

                case "2":
                    Console.Write("Convert from Kilometers (Press A), Meters (B) or Centimeters (C): ");
                    string selection2 = Console.ReadLine();

                    if (selection2 == "A")
                    {
                        Console.Write("Enter a value in Kilometers: ");

                        kmF = UnitConverter.KmtoFeet(Console.ReadLine());

                        Console.WriteLine("Feet = " + kmF);
                    }
                    if (selection2 == "B")
                    {
                        Console.Write("Enter a value in Meters: ");

                        mF = UnitConverter.MtoFeet(Console.ReadLine());

                        Console.WriteLine("Feet = " + mF);
                    }
                    if (selection2 == "C")
                    {
                        Console.Write("Enter a value in Centimeters: ");

                        cmF = UnitConverter.CmtoFeet(Console.ReadLine());

                        Console.WriteLine("Feet = " + cmF);
                    }
                    break;

                case "3":
                    Console.Write("Convert from Kilometers (Press A), Meters (B) or Centimeters (C): ");
                    string selection3 = Console.ReadLine();

                    if (selection3 == "A")
                    {
                        Console.Write("Enter a value in Kilometers: ");

                        kmM = UnitConverter.KmtoMiles(Console.ReadLine());

                        Console.WriteLine("Miles = " + kmM);
                    }
                    if (selection3 == "B")
                    {
                        Console.Write("Enter a value in Meters: ");

                        mM = UnitConverter.MtoMiles(Console.ReadLine());

                        Console.WriteLine("Miles = " + mM);
                    }
                    if (selection3 == "C")
                    {
                        Console.Write("Enter a value in Centimeters: ");

                        cmM = UnitConverter.CMtoMiles(Console.ReadLine());

                        Console.WriteLine("Miles = " + cmM);
                    }
                    break;

                case "4":
                    Console.Write("Convert from Kilometers (Press A), Meters (B) or Centimeters (C): ");
                    string selection4 = Console.ReadLine();

                    if (selection4 == "A")
                    {
                        Console.Write("Enter a value in Kilometers: ");

                        kmY = UnitConverter.KmtoYards(Console.ReadLine());

                        Console.WriteLine("Yards = " + kmY);
                    }
                    if (selection4 == "B")
                    {
                        Console.Write("Enter a value in Meters: ");

                        mY = UnitConverter.MtoYards(Console.ReadLine());

                        Console.WriteLine("Yards = " + mY);
                    }
                    if (selection4 == "C")
                    {
                        Console.Write("Enter a value in Centimeters: ");

                        cmY = UnitConverter.CmtoYards(Console.ReadLine());

                        Console.WriteLine("Yards = " + cmY);
                    }
                    break;

                default:
                    Console.WriteLine("please select something to convert");
                    break;
            }
            Console.WriteLine("Do you want to continue? \n Press 1 if so, or to exit press any other key.");
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
        //Yards conversion
        public static double KmtoYards(string unitKMtoY)
        {
            double kmY = double.Parse(unitKMtoY);

            double yards = (kmY * 1093.61);

            return yards;
        }
        public static double MtoYards(string unitMtoY)
        {
            double mY = double.Parse(unitMtoY);

            double yards = (mY * (1093.61 / 1000));

            return yards;
        }
        public static double CmtoYards(string unitCmtoY)
        {
            double cmY = double.Parse(unitCmtoY);

            double yards = (cmY * (1093.61 / 100000));

            return yards;
        }
    }
}
