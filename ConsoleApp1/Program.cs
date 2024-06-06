using System.Diagnostics.Metrics;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a=3, b = 2, c = 0;
            //Console.Write("Valeur de a = ");
            //Console.WriteLine(a);
            //Console.Write("Valeur de b = ");
            //Console.WriteLine(b);

            //Console.WriteLine("PERMUTATION");
            //// on utilise variable c pour faire un echange entre a et b
            //c = a;
            //a = b;
            //b = c;
            //Console.Write("Valeur de a = ");
            //Console.WriteLine(a);
            //Console.Write("Valeur de b = ");
            //Console.WriteLine(b);

            //string userEntry1 = Console.ReadLine();
            //string userEntry2 = Console.ReadLine();           
            //Console.WriteLine( userEntry1 + userEntry2);

            ////Request numbers for calculations
            //Console.Write("Type a number:");
            // string number1AsString = Console.ReadLine();
            // Console.Write("Type a second number: ");
            // string number2AsString = Console.ReadLine();

            // //Converting into numbers
            // int number1 = Convert.ToInt32(number1AsString);
            // int number2 = Convert.ToInt32(number2AsString);

            // //Request the success message          
            // Console.Write("Enter success message: ");
            // string MessageAsString = Console.ReadLine();

            // //Сalculate and convert to string
            // string ResultatAsString = Convert.ToString(number1 + number2);

            // //Output the result in the required format
            // Console.Write("[" + number1AsString + "] + " + "[" + number2AsString + "] = [" + ResultatAsString + "]\n ");
            // Console.WriteLine(MessageAsString);

            //Request numbers for calculations
            Console.Write("Limit1: ");
            string number1AsString = Console.ReadLine();
            Console.Write("Limit2: ");
            string number2AsString = Console.ReadLine();
            Console.Write("Integer: ");
            string number3AsString = Console.ReadLine();
            //Declaration of variables 
            string resultatIf = "", boundIf = "", maxOrMin = "", messageresultat = "";
            string resultingInteger = number3AsString;
            bool isTheNumberLimited = true;

            //Converting into numbers
            int limit1 = Convert.ToInt32(number1AsString);
            int limit2  = Convert.ToInt32(number2AsString);
            int number1 = Convert.ToInt32(number3AsString);
            
            //Сhecking the limits
            if (limit2 > limit1)
            {
                Console.Write("Limit 2 is greater than Limit 1. Try again!");
                return;
            }

            //Сhecking whether the number is within the specified limits
            if (number1 > limit1)
            {
                isTheNumberLimited  = false;
                resultatIf          = "greater";
                boundIf             = number1AsString;
                maxOrMin            = "maximum";
                resultingInteger    = number1AsString;
            }
            else if (number1 < limit2)
            {
                isTheNumberLimited  = false;
                resultatIf          = "lower";
                boundIf             = number2AsString;
                maxOrMin            = "minimum";
                resultingInteger    = number2AsString;
            }
            
            if (isTheNumberLimited)
            {
                messageresultat = "OK";
            }
            else
            {
                messageresultat = "You have entered " + number3AsString + " which is " + resultatIf + " then " + boundIf + " which is the " + maxOrMin;
            }

            Console.Write(messageresultat);
            Console.Write("\n Resulting integer: "+ resultingInteger);
            

        }
    }
}
