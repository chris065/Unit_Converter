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

            //1KG = 0.000984207 Imperial Ton
            //KG = 0.157473 Stone
            //1KG = 2.20462 Pounds
            //1KG = 35.274 Ounce
<<<<<<< HEAD
=======
            Console.WriteLine("***Unit Converter 1.3***");
>>>>>>> c816231b8a8319e34f342566d2c0cacdaf875925

            //1AU = 1.5x10^11 M
            //1Pc = 3.26 ly
            //1Pc = 2.06x10^5 AU
            //1Pc = 3.08x10^16 M
            //1 ly = 9.46x10^15 M

            //1 L = 0.219969 Imperial Gallon
            //1 L = 0.879876 Imperial Quart
            //1 L = 1.759752 Imperial Pint
            //1 L = 3.519504 Imperial Cup
            //1 l = 35.19503 Imperial Fluid Ounce

           /*To work out distance in meters from light distance:
            use the equation s(distance) = v * t (velocity * time) where the speed of light is equal to 3x10^8
            so for a light day you know the speed of light so times that by 24 * 60 * 60 (because you have to convert the length of the day into seconds).*/

            Console.WriteLine("***Unit Converter 1.4 BETA***");

            Console.WriteLine("\n");
            Start:
            Console.WriteLine("\n***Metric To Imperial***");

            Console.WriteLine("\n****Lengths****");
            Console.WriteLine("Press 1 To convert from Metric to Inches "); //asking for user input

            Console.WriteLine("Press 2 To convert from Metric to Feet");

            Console.WriteLine("Press 3 To convert from Metric to Miles");

            Console.WriteLine("Press 4 to convert from Metric to Yards");

            Console.WriteLine("\n****Temperature****");

            Console.WriteLine("Press 5 To convert from Celsius to Fahrenheit");

            Console.WriteLine("Press 6 to convert from Celsus to Kelvin");

            Console.WriteLine("Press 7 to convert from Fahrenheit to Kelvin");


            Console.WriteLine("\n****Mass****");
            Console.WriteLine("Press 8 to convert from Metric to Impreial Ton");

            Console.WriteLine("Press 9 to convert from Metric to Stone");

            Console.WriteLine("Press 10 to convert from Metric to Pounds");

            Console.WriteLine("Press 11 to convert from Metric to Ounces");


            Console.WriteLine("\n****Astronomy****");
            Console.WriteLine("Press 12 to convert from AU (Astronomical Unit) to meters");

            Console.WriteLine("Press 13 to convert from Light Distance to meters");

            Console.WriteLine("Press 14 to convert from Parsec to other units");


            Console.WriteLine("\n****Volume****");
            Console.WriteLine("Press 15 to convert from Metric to Imperial Gallon");

            Console.WriteLine("Press 16 to convert from Metric to Imperial Quart");

            Console.WriteLine("Press 17 to convert from Metric to Imperial Pint");

            Console.WriteLine("Press 18 to convert from Metric to Imperial Cup");

            Console.WriteLine("Press 19 to convert from Metric to Imperial Fluid Ounce");

            Console.Write("\n = ");

            string input = Console.ReadLine();

            double km, m, cm, kmF, mF, cmF, kmM, mM, cmM, kmY, mY, cmY = 0; //lenghts

            double cF, cK, fK = 0; //temp

            double kg, g, mg, kS, gS, mS, kP, gP, mP, kO, gO, mO = 0; //mass

            double AU, LD, LM, LY, pAU, pM, pLY = 0; // Astro

            double lIG, mlIG, lIQ, mLIQ, lIP, mLIP, lIC, mLIC, lFO, mLFO = 0; //Volume


            switch (input) //using switch statement as it is easier to read for other developers and users.
            {
                case "1": //inches conversion

                    Console.Write("Convert from Kilometers (Press A), Meters (B) or Centimeters (C): ");
                    string selection1 = Console.ReadLine();

                    if (selection1 == "A" || selection1 == "a")
                    {
                        Console.Write("Enter a value in Kilometers: ");

                        km = UnitConverter.KmToInches(Console.ReadLine());

                        Console.WriteLine("\n Inches = " + km);
                    }
                    if (selection1 == "B" || selection1 == "b")
                    {
                        Console.Write("Enter a value in Meters: ");

                        m = UnitConverter.MToInches(Console.ReadLine());

                        Console.WriteLine("\n Inches = " + m);
                    }
                    if (selection1 == "C" || selection1 == "c")
                    {
                        Console.Write("Enter a value in Centimeters: ");

                        cm = UnitConverter.CmToInches(Console.ReadLine());

                        Console.WriteLine("\n Inches = " + cm);
                    }

                    break;

                case "2": //feet conversion
                    Console.Write("Convert from Kilometers (Press A), Meters (B) or Centimeters (C): ");
                    string selection2 = Console.ReadLine();

                    if (selection2 == "A" || selection2 == "a")
                    {
                        Console.Write("Enter a value in Kilometers: ");

                        kmF = UnitConverter.KmtoFeet(Console.ReadLine());

                        Console.WriteLine("\nFeet = " + kmF);
                    }
                    if (selection2 == "B" || selection2 == "b")
                    {
                        Console.Write("Enter a value in Meters: ");

                        mF = UnitConverter.MtoFeet(Console.ReadLine());

                        Console.WriteLine("\nFeet = " + mF);
                    }
                    if (selection2 == "C" || selection2 == "c")
                    {
                        Console.Write("Enter a value in Centimeters: ");

                        cmF = UnitConverter.CmtoFeet(Console.ReadLine());

                        Console.WriteLine("\nFeet = " + cmF);
                    }
                    break;

                case "3": //miles conversion
                    Console.Write("Convert from Kilometers (Press A), Meters (B) or Centimeters (C): ");
                    string selection3 = Console.ReadLine();

                    if (selection3 == "A" || selection3 == "a")
                    {
                        Console.Write("Enter a value in Kilometers: ");

                        kmM = UnitConverter.KmtoMiles(Console.ReadLine());

                        Console.WriteLine("\nMiles = " + kmM);
                    }
                    if (selection3 == "B" || selection3 == "b")
                    {
                        Console.Write("Enter a value in Meters: ");

                        mM = UnitConverter.MtoMiles(Console.ReadLine());

                        Console.WriteLine("\nMiles = " + mM);
                    }
                    if (selection3 == "C" || selection3 == "c")
                    {
                        Console.Write("Enter a value in Centimeters: ");

                        cmM = UnitConverter.CMtoMiles(Console.ReadLine());

                        Console.WriteLine("\nMiles = " + cmM);
                    }
                    break;

                case "4": //yards conversion
                    Console.Write("Convert from Kilometers (Press A), Meters (B) or Centimeters (C): ");
                    string selection4 = Console.ReadLine();

                    if (selection4 == "A" || selection4 == "a")
                    {
                        Console.Write("Enter a value in Kilometers: ");

                        kmY = UnitConverter.KmtoYards(Console.ReadLine());

                        Console.WriteLine("\nYards = " + kmY);
                    }
                    if (selection4 == "B" || selection4 == "b")
                    {
                        Console.Write("Enter a value in Meters: ");

                        mY = UnitConverter.MtoYards(Console.ReadLine());

                        Console.WriteLine("\nYards = " + mY);
                    }
                    if (selection4 == "C" || selection4 == "c")
                    {
                        Console.Write("Enter a value in Centimeters: ");

                        cmY = UnitConverter.CmtoYards(Console.ReadLine());

                        Console.WriteLine("\nYards = " + cmY);
                    }
                    break;

                case "5": //fahrenheit conversion
                    Console.Write("Enter a value in Celsius: ");

                    cF = UnitConverter.CtoF(Console.ReadLine());

                    Console.WriteLine("\nFahrenheit = " + cF);

                    break;
                case "6": //kelvin conversion
                    Console.Write("Enter a value in Celsius: ");

                    cK = UnitConverter.CtoK(Console.ReadLine());

                    Console.WriteLine("\nKelvin = " + cK);
                    break;
                case "7": //f to kelvin conversion
                    Console.Write("Enter a value in Fahrenheit: ");

                    fK = UnitConverter.FtoK(Console.ReadLine());

                    Console.WriteLine("\nKelvin = " + Math.Round(fK, 3));
                    break;
                case "8": //Mass Conversion
                    Console.Write("To Convert from Kilograms (Press A), Grams (B) or Miligrams (C)");
                    string selection5 = Console.ReadLine();
                    if (selection5 == "A" || selection5 == "a")
                    {
                        Console.Write("Enter a value in Kilograms: ");

                        kg = UnitConverter.KGtoTon(Console.ReadLine());

                        Console.WriteLine("\nImperial Ton = " + kg);
                    }
                    if (selection5 == "B" || selection5 == "b")
                    {
                        Console.Write("Enter a value in Grams: ");

                        g = UnitConverter.GtoTon(Console.ReadLine());

                        Console.WriteLine("\nImperial Ton = " + g);
                    }
                    if (selection5 == "C" || selection5 == "c")
                    {
                        Console.Write("Enter a value in Miligrams: ");

                        mg = UnitConverter.MGtoTon(Console.ReadLine());

                        Console.WriteLine("\nImperial Ton = " + mg);
                    }
                    break;
                case "9":
                    Console.Write("To convert to from Kilograms (Press A), Grams (B) or Miligrams (C): ");
                    string selection6 = Console.ReadLine();

                    if (selection6 == "A" || selection6 == "a")
                    {
                        Console.Write("Enter a value in Kilograms: ");

                        kS = UnitConverter.KGtoStone(Console.ReadLine());

                        Console.WriteLine("\nStones = " + kS);
                    }
                    if (selection6 == "B" || selection6 == "b")
                    {
                        Console.Write("Enter a value in Grams: ");

                        gS = UnitConverter.GtoStone(Console.ReadLine());

                        Console.WriteLine("\nStones = " + gS);
                    }
                    if (selection6 == "C" || selection6 == "c")
                    {
                        Console.Write("Enter a value in Miligrams: ");

                        mS = UnitConverter.MGtoStone(Console.ReadLine());

                        Console.WriteLine("\nStones = " + mS);
                    }
                    break;
                    //Pounds Conversion
                case "10":
                    Console.Write("To convert from Kilograms (Press A), Grams (B) or Miligrams (C)");
                    string selection7 = Console.ReadLine();

                    if (selection7 == "A" || selection7 == "a")
                    {
                        Console.Write("Enter a value in Kilograms: ");

                        kP = UnitConverter.KGtoPounds(Console.ReadLine());

                        Console.WriteLine("\nPounds = " + kP);
                    }
                    if (selection7 == "B" || selection7 == "b")
                    {
                        Console.Write("Enter a value in Grams: ");

                        gP = UnitConverter.GtoPounds(Console.ReadLine());

                        Console.WriteLine("\nPounds = " + gP);
                    }
                    if (selection7 == "C" || selection7 == "c")
                    {
                        Console.Write("Enter a value in Miligrams: ");

                        mP = UnitConverter.MGtoPounds(Console.ReadLine());

                        Console.WriteLine("\nPounds = " + mP);
                    }
                    break;
                case "11":
                    Console.Write("To convert from Kilograms (Press A), Grams (B) or Miligrams (C): ");
                    string selection8 = Console.ReadLine();

                    if (selection8 == "A" || selection8 == "a")
                    {
                        Console.Write("Enter a value in Kilograms: ");

                        kO = UnitConverter.KGtoOunce(Console.ReadLine());

                        Console.WriteLine("\n Ounces = " + kO);
                    }
                    if (selection8 == "B" || selection8 == "b")
                    {
                        Console.Write("Enter a value in Grams: ");

                        gO = UnitConverter.GtoOunce(Console.ReadLine());

                        Console.WriteLine("\n Ounces = " + gO);
                    }
                    if (selection8 == "C" || selection8 == "c")
                    {
                        Console.Write("Enter a value in Miligrams: ");

                        mO = UnitConverter.MGtoOunce(Console.ReadLine());

                        Console.WriteLine("\n Ounces = " + mO);
                    }
                    break;

                case "12":
                    Console.Write("Enter a value in AU: ");

                    AU = UnitConverter.AUtoMeter(Console.ReadLine());

                    Console.WriteLine("\n Meters = " + AU);
                    break;
                case "13":
                    Console.Write("To convert from Light Days (Press A), Months (B) or Years (C): ");
                    string selection9 = Console.ReadLine();

                    if (selection9 == "A" || selection9 == "a")
                    {
                        Console.Write("Enter a value in Light Days: ");

                        LD = UnitConverter.LDtoMeter(Console.ReadLine());

                        Console.WriteLine("\n Meters = " + LD);
                    }
                    if (selection9 == "B" || selection9 == "b")
                    {
                        Console.Write("Enter a value in Light Months: ");

                        LM = UnitConverter.LMtoMeter(Console.ReadLine());

                        Console.WriteLine("\n Meters = " + LM);
                    }
                    if (selection9 == "C" || selection9 == "c")
                    {
                        Console.Write("Enter a value in Light Years: ");

                        LY = UnitConverter.LYtoMeter(Console.ReadLine());

                        Console.WriteLine("\n Meters = " + LY);
                    }

                    break;
                case "14":
                    Console.Write("To convert from Parsec to AU Press (A), Meter (B) or Light Years (C): ");
                    string selection10 = Console.ReadLine();

                    if (selection10 == "A" || selection10 == "a")
                    {
                        Console.Write("Enter a value in Parsecs: ");

                        pAU = UnitConverter.PtoAU(Console.ReadLine());

                        Console.WriteLine("AU = " + pAU);
                    }
                    if (selection10 == "B" || selection10 == "b")
                    {
                        Console.Write("Enter a value in Parsecs: ");

                        pM = UnitConverter.PtoM(Console.ReadLine());

                        Console.WriteLine("Meters = " + pM);
                    }
                    if (selection10 == "C" || selection10 == "c")
                    {
                        Console.Write("Enter a value in Parsecs: ");

                        pLY = UnitConverter.PtoLY(Console.ReadLine());

                        Console.WriteLine("Light Years = " + pLY);
                    }
                    break;
                default:
                    Console.WriteLine("please select something to convert");
                    break;
            }
            Console.WriteLine("\nDo you want to continue? \n Press 1 if so, or to exit press any other key.");
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
        //tempreature conversion
        public static double CtoF(string unitCtoF)
        {
            double cf = double.Parse(unitCtoF);

            double f = (cf * 9/5 + 32);

            return f;
        }
        public static double CtoK(string unitCtoK)
        {
            double ck = double.Parse(unitCtoK);

            double k = (ck + 273.15);

            return k;
        }
        public static double FtoK(string unitFtoK)
        {
            double fk = double.Parse(unitFtoK);

            double k = ((fk + 459.67) * 5 / 9);

            return k;
        }
        //Mass Conversion

        //Ton Conversion
        public static double KGtoTon(string unitKGtoT)
        {
            double kg = double.Parse(unitKGtoT);

            double ton = (kg * 0.000984207);

            return ton;
        }
        public static double GtoTon(string unitGtoT)
        {
            double g = double.Parse(unitGtoT);

            double ton = (g * (0.000984207 / 1000));

            return ton;
        }
        public static double MGtoTon(string unitMGtoT)
        {
            double mg = double.Parse(unitMGtoT);

            double ton = (mg * (0.000984207 / 100000));

            return ton;
        }
        //Stone Conversion
        public static double KGtoStone(string unitKtoS)
        {
            double kg = double.Parse(unitKtoS);

            double stone = (kg * 0.157473);

            return stone;
        }
        public static double GtoStone(string unitGtoS)
        {
            double g = double.Parse(unitGtoS);

            double stone = (g * (0.157473 / 1000));

            return stone;
        }
        public static double MGtoStone(string unitMGtoS)
        {
            double mg = double.Parse(unitMGtoS);

            double stone = (mg * (0.157473 / 100000));

            return stone;
        }
        //Pounds Conversion
        public static double KGtoPounds(string unitKGtoP)
        {
            double kg = double.Parse(unitKGtoP);

            double pounds = (kg * 2.20462);

            return pounds;
        }
        public static double GtoPounds(string unitGtoP)
        {
            double g = double.Parse(unitGtoP);

            double pounds = (g * (2.20462 / 1000));

            return pounds;
        }
        public static double MGtoPounds(string unitMGtoP)
        {
            double mg = double.Parse(unitMGtoP);

            double pounds = (mg * (2.20462 / 100000));

            return pounds;
        }
        //Ounce Conversion
        public static double KGtoOunce(string unitKGtoO)
        {
            double kg = double.Parse(unitKGtoO);

            double ounce = (kg * 35.274);

            return ounce;
        }
        public static double GtoOunce(string unitGtoO)
        {
            double g = double.Parse(unitGtoO);

            double ounce = (g * (35.274 / 1000));

            return ounce;
        }
        public static double MGtoOunce(string unitMGtoO)
        {
            double mg = double.Parse(unitMGtoO);

            double ounce = (mg * (35.274 / 100000));

            return ounce;
        }
        //Astronomy Units
        public static double AUtoMeter(string unitAUtoM)
        {
            double m = double.Parse(unitAUtoM);

            double AU = (m * 150000000000);

            return AU;
        }
        public static double LDtoMeter(string unitLDtoM)
        {
            double m = double.Parse(unitLDtoM);

           double lD = (m * (300000000UL * (24 * 60 * 60)));

            return lD;
        }
        public static double LMtoMeter(string unitLMtoM)
        {
            double m = double.Parse(unitLMtoM);

            double lM = (m * (300000000UL * (31 * 24 * 60 * 60)));

            return lM;
        }
        public static double LYtoMeter(string unitLYtoM)
        {
            double m = double.Parse(unitLYtoM);

            double lY = (m * (300000000UL * (365.25 * 24 * 60 * 60)));

            return lY;
        }
        public static double PtoAU(string unitPtoAU)
        {
            double p = double.Parse(unitPtoAU);

            double AU = (p * 2060000);

            return AU;
        }
        public static double PtoM(string unitPtoM)
        {
            double p = double.Parse(unitPtoM);

            double m = (p * 30800000000000000);

            return m;
        }
        public static double PtoLY(string unitPtoLY)
        {
            double p = double.Parse(unitPtoLY);

            double LY = (p * 3.26);

            return LY;
        }
        //Volume Conversion
        public static double LtoGall(string unitLtoG)
        {
            double l = double.Parse(unitLtoG);

            double Gall = (l * 0.219969);

            return Gall;
        }
        public static double mLToGall(string unitMLtoG)
        {
            double mL = double.Parse(unitMLtoG);

            double Gall = (mL * (0.219969 / 1000));

            return Gall;
        }
        public static double LtoIQ(string unitLtoIQ)
        {
            double l = double.Parse(unitLtoIQ);

            double IQ = (l * 0.879876);

            return IQ;
        }
        public static double mLToIQ(string unitMLtoIQ)
        {
            double mL = double.Parse(unitMLtoIQ);

            double IQ = (mL * (0.879876 / 1000));

            return IQ;
        }
        public static double LToPint(string unitLtoP)
        {
            double l = double.Parse(unitLtoP);

            double pint = (l * 1.759752);

            return pint;
        }
        public static double mLtoPint(string unitMLtoP)
        {
            double mL = double.Parse(unitMLtoP);

            double pint = (mL * (1.759752 / 1000));

            return pint;
        }
        public static double LtoCup(string unitLtoC)
        {
            double l = double.Parse(unitLtoC);

            double cup = (l * 3.519504);

            return cup;
        }
        public static double mLtoCup(string unitMLtoC)
        {
            double mL = double.Parse(unitMLtoC);

            double cup = (mL * (3.519504 / 1000));

            return cup;
        }
        public static double LtoFO(string unitLtoFO)
        {
            double l = double.Parse(unitLtoFO);

            double FO = (l * 35.19503);

            return FO;
        }
        public static double mLtoFO(string unitMLtoFO)
        {
            double mL = double.Parse(unitMLtoFO);

            double FO = (mL * (35.19503 / 1000));

            return FO;
        }
    }
}
