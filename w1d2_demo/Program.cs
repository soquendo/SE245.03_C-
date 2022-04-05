using System; //like the import in python, initializing the file for the data it's using
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w1d2_demo //project name
{
    class Program //type of app
    {
        static void Main(string[] args)
        {
            
            //variables by type
            String strFirst, strOperand, strNum1, strNum2;
            Int32 intNum1 = 0, intNum2 = 0, intNum3, intResult = 0;
            Double dblResult;

            //print / output statement
            Console.WriteLine("Hello There!");

            //user input and print
            Console.Write("Please enter your first name: ");
            strFirst = Console.ReadLine();

            //concatenation
            Console.WriteLine("Hello " + strFirst + "! Let's do some math!");

            //user input and print
            Console.Write("Please enter the first number: ");
            strNum1 = Console.ReadLine();


            Console.Write("Please enter the math operation (PLUS, MINUS, MULTIPLY, DIVIDE): ");
            strOperand = Console.ReadLine();

            Console.Write("Please enter the second number: ");
            strNum2 = Console.ReadLine();

            //two different methods of converting to integers
            intNum1 = Int32.Parse(strNum1);

            intNum2 = Convert.ToInt32(strNum2);

            
            switch (strOperand) //a series of "if" statements
            {
                
                //arithmetic operations
                case "PLUS":
                    intResult = intNum1 + intNum2;
                    break;
                case "MINUS":
                    intResult = intNum1 - intNum2;
                    break;
                case "MULTIPLY":
                    intResult = intNum1 * intNum2;
                    break;
                case "DIVIDE":
                    intResult = intNum1 / intNum2;
                    break;

            }

            //answer
            dblResult = (Double)intResult;


            //if and else if statements with a print message for each
            if (strOperand == "PLUS")
            {

                Console.WriteLine("\n\nThe sum of " + intNum1 + " and " + intNum2 + " equals: " + dblResult);
            }
            else if (strOperand == "MINUS") //interpolation

            {

                Console.WriteLine($"\n\nThe sum of {intNum1} and {intNum2} equals: {dblResult}");
            }
            else if (strOperand == "DIVIDE")
            {

                Console.WriteLine($"\n\nThe quotient of {intNum1} and {intNum2} equals:{dblResult}");
            }

            //input message upon completion of program run
            Console.WriteLine("\n\nPress Any Key to Continue");
            Console.ReadKey();

        }
    }
}
