﻿using System;
using System.Diagnostics.Metrics;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Les conditions
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

            //Un tableau
            //Array declaration
            int[] intArray1 = new int[3] { 1,2,3};
            int[] intArray2 = new int[3] { 4,5,6};

            //Сalculating the length of the 3rd array
            int LengthArray1 = intArray1.Length ;
            int LengthArray2 = intArray2.Length ;
            int LengthArray3 = LengthArray1 + LengthArray2;
            int[] intArray3 = new int[LengthArray3];

            //Filling the 3rd array
            for (int i = 0; i < LengthArray1; i++)
            {
                intArray3[i] = intArray1[i];
                Console.Write(intArray3[i]);
            }
            
            for (int i = LengthArray1; i < LengthArray3; i++)
            {
                intArray3[i] = intArray2[i- LengthArray1];
                Console.Write(intArray3[i]);
            }
        }
    }
}
