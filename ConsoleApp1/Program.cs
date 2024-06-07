using System;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata.Ecma335;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LES CONDITIONS------------------------------>>
            ////Request numbers for calculations
            //Console.Write("Limit1: ");
            //string number1AsString = Console.ReadLine();
            //Console.Write("Limit2: ");
            //string number2AsString = Console.ReadLine();
            //Console.Write("Integer: ");
            //string number3AsString = Console.ReadLine();
            ////Declaration of variables 
            //string resultatIf = "", boundIf = "", maxOrMin = "", messageresultat = "";
            //string resultingInteger = number3AsString;
            //bool isTheNumberLimited = true;

            ////Converting into numbers
            //int limit1 = Convert.ToInt32(number1AsString);
            //int limit2 = Convert.ToInt32(number2AsString);
            //int number1 = Convert.ToInt32(number3AsString);

            ////Сhecking the limits
            //if (limit2 > limit1)
            //{
            //    Console.Write("Limit 2 is greater than Limit 1. Try again!");
            //    return;
            //}

            ////Сhecking whether the number is within the specified limits
            //if (number1 > limit1)
            //{
            //    isTheNumberLimited = false;
            //    resultatIf = "greater";
            //    boundIf = number1AsString;
            //    maxOrMin = "maximum";
            //    resultingInteger = number1AsString;
            //}
            //else if (number1 < limit2)
            //{
            //    isTheNumberLimited = false;
            //    resultatIf = "lower";
            //    boundIf = number2AsString;
            //    maxOrMin = "minimum";
            //    resultingInteger = number2AsString;
            //}

            //if (isTheNumberLimited)
            //{
            //    messageresultat = "OK";
            //}
            //else
            //{
            //    messageresultat = "You have entered " + number3AsString + " which is " + resultatIf + " then " + boundIf + " which is the " + maxOrMin;
            //}

            //Console.Write(messageresultat);
            //Console.Write("\n Resulting integer: " + resultingInteger);
            ////<<-----------------------------LES CONDITIONS




            ////UN TABLEAU-------------------------------->>
            ////Array declaration
            //int[] intArray1 = new int[3] { 1,2,3};
            //int[] intArray2 = new int[3] { 4,5,6};

            ////Сalculating the length of the 3rd array
            //int LengthArray1 = intArray1.Length ;
            //int LengthArray2 = intArray2.Length ;
            //int LengthArray3 = LengthArray1 + LengthArray2;
            //int[] intArray3 = new int[LengthArray3];

            ////Filling the 3rd array
            //for (int i = 0; i < LengthArray1; i++)
            //{
            //    intArray3[i] = intArray1[i];
            //    Console.Write(intArray3[i]);
            //}

            //for (int i = LengthArray1; i < LengthArray3; i++)
            //{
            //    intArray3[i] = intArray2[i- LengthArray1];
            //    Console.Write(intArray3[i]);
            //}
            //<<---------------------------------------UN TABLEAU




            //// LES BOUCLES---------------------------------->>
            //// AddValues() -- i'is a function for every iteration 
            //// First iteration
            //AddValues();

            ////Asking numbers of iterations and running
            //int nomberOfiterations  = 0;
            //Console.Write("Rentrez le nombre d'itérations: ");
            //string nomberOfiterationsString = Console.ReadLine();

            //if (int.TryParse(nomberOfiterationsString, out int number))
            //{
            //    nomberOfiterations = Convert.ToInt32(nomberOfiterationsString);
            //};

            //for (int i=0; i< nomberOfiterations; i++)
            //{
            //    AddValues();
            //}
            ////<<---------------------------------------------LES BOUCLES



            //LES FONCTIONS--------------------------------------------->>
            bool itsNotFin = true;
            while (itsNotFin)
            {
                Double NumberFromUser1 = AskingEnterTheNumber(1);
                Double NumberFromUser2 = AskingEnterTheNumber(2);

               
                Console.Write("which operation you choose: ");
                string chosedOperationByUser = Console.ReadLine();
                if (chosedOperationByUser == null )
                {
                    Console.WriteLine("The values possible add; multiply; dividee; substract");
                }
                else
                {
                    if (chosedOperationByUser.ToLower() == "add")
                    {
                        double ReueltatOfCalcules = FunctionMatADD(NumberFromUser1, NumberFromUser2);
                        string stringToPrint = PreparatingTheTextToPrint("+", NumberFromUser1, NumberFromUser2);
                        Console.Write(stringToPrint);
                        Console.WriteLine(ReueltatOfCalcules);
                    }
                    if (chosedOperationByUser.ToLower() == "multiply")
                    {
                        double ReueltatOfCalcules = FunctionMatMULITPLY(NumberFromUser1, NumberFromUser2);
                        string stringToPrint = PreparatingTheTextToPrint("*", NumberFromUser1, NumberFromUser2);
                        Console.Write(stringToPrint);
                        Console.WriteLine(ReueltatOfCalcules);
                    }
                    if (chosedOperationByUser.ToLower() == "dividee")
                    {
                        double ReueltatOfCalcules = FunctionMatDIVIDEE(NumberFromUser1, NumberFromUser2);
                        string stringToPrint = PreparatingTheTextToPrint("/", NumberFromUser1, NumberFromUser2);
                        Console.Write(stringToPrint);
                        Console.WriteLine(ReueltatOfCalcules);
                    }
                    if (chosedOperationByUser.ToLower() == "substract")
                    {
                        double ReueltatOfCalcules = FunctionMatSUBSTRACT(NumberFromUser1, NumberFromUser2);
                        string stringToPrint = PreparatingTheTextToPrint("/", NumberFromUser1, NumberFromUser2);
                        Console.Write(stringToPrint);
                        Console.WriteLine(ReueltatOfCalcules);
                    }
                }

            }


            //<<---------------------------------------------LES FONCTIONS
        }
        ///////////////////////////////////////////////////////////////////////////////////////////

        //Function for exercise "LES BOUCLES"
        static void AddValues()
        {
            //Declaration of variables
            string[] moves = new string [32];
            string stepEteredByUser = "", stepEteredByUserUpper = "";
            bool itsNotFin = true;
            int lenghtOfArray = moves.Length;
            int currentStep = 0;

            while (itsNotFin)
            {
                
                if (stepEteredByUserUpper == "DONE" || currentStep > lenghtOfArray-1)
                {
                    
                    itsNotFin = false;
                }
                else
                {
                    Console.Write("Rentrez un pas de danse: ");
                    stepEteredByUser = Console.ReadLine();
                    stepEteredByUserUpper = stepEteredByUser.ToUpper();
                    moves[currentStep] = stepEteredByUser;

                }
                currentStep = currentStep + 1;

            }
            int i= 0;
            itsNotFin = true;
            while (itsNotFin)
            {
                 Console.Write(moves[i] + "\n");
                 
                 if (moves[i] == null ||  moves[i].ToUpper() == "DONE" || i == lenghtOfArray -1)
                    
                 {
                     itsNotFin = false;
                 }
                i = i + 1;
            }
                
            
            
        }

        //Functions for exercise "LES FONCTIONS"
        static string PreparatingTheTextToPrint (string currantOperationChosed, double number1, double number2)
        {
           string stringNumber1 = Convert.ToString(number1);
           string stringNumber2 = Convert.ToString(number2);
           return stringNumber1 + currantOperationChosed +" "+ stringNumber2+ " = ";
            
        }

        static double AskingEnterTheNumber (int numberOfArgument)
        {
            double doubleStringFromUser1 = 0;
            string StringOfArgument = "first ";

            if (numberOfArgument !=1)
            {
                StringOfArgument = "second ";
            }
            Console.Write(StringOfArgument + " operand: ");
            string StringFromUser1 = Console.ReadLine();
            if (double.TryParse(StringFromUser1, out double number))
            {
                doubleStringFromUser1 = Convert.ToDouble(StringFromUser1);
            }
            else
            {
                Console.Write("It's not a number. I will take 0! \n");
               
            }
            return doubleStringFromUser1;
        }


        static double FunctionMatADD(double Valu1, double value2)
        {
           return Valu1 + value2;
        }

        static double FunctionMatMULITPLY (double Valu1, double value2)
        {
            return Valu1 * value2;
        }

        static double FunctionMatDIVIDEE(double Valu1, double value2)
        {
           if (value2 != 0 )
            {
                return Valu1 / value2;
            }
            else
            {
                return 0;
            }

        }
        static double FunctionMatSUBSTRACT(double Valu1, double value2)
        {
            return Valu1 - value2;
        }
    }
    

}
