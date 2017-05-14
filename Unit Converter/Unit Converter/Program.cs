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
            Console.WriteLine("= ");

            string input = Console.ReadLine();

            switch (input) //using switch statement as it is easier to read for other developers and users.
            {
                case "1":
                    Console.WriteLine("Enter a value in kilometers: ");
                    break;

                case "2":
                    Console.WriteLine("Enter a value in meters: ");
                    break;

                case "3":
                    Console.WriteLine("Enter a value in centimeters: ");
                    break;

                default:
                    Console.WriteLine("please select something to convert");
                    break;
            }
        }
    }
    public class UnitConverter //class where methods are stored for each conversion
    {
        public static int KmToInches(string unitKilometer)
        {
            return 1;
        }
        public static int MToInches(string unitMeter)
        {
            return 1;
        }
        public static int CmToInches(string unitCentimeter)
        {
            return 1;
        }
    }
}
