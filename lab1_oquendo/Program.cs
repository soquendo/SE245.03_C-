//Sebastian Oquendo
//Lab 1
//04-07-22
//SE244.03


//Grade calculator

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_oquendo
{
    class Program
    {
        static void Main(string[] args)


        {
            Int32 intNum1 = 0, intNum2 = 0, intNum3 = 0, intNum4 = 0, finalGrade = 0;

            Double hwFinal = 0, partFinal = 0, quizFinal = 0, examFinal = 0, dblNum1 = 0, dblNum2 = 0, dblNum3;

            String strFirst, strNum1, strNum2, strNum3, strNum4;


            //hwGrade = 20% of final grade
            hwFinal = intNum1 * .20;

            //partGrade = 20% of final grade
            partFinal = intNum2 * .20;

            //quizGrade = 25% of final grade
            quizFinal = intNum3 * .25;

            //examGrade = 35% of final grade
            examFinal = intNum4 * .35;

            Console.Write("Please enter student name: ")
            strFirst = Console.ReadLine();

            Console.Write("Enter your homework grade [0-100]: ");
            strNum1 = Console.ReadLine();    

            Console.Write("Enter your participation grade [0-100]: ");
            strNum2 = Console.ReadLine();

            Console.Write("Enter your quiz grade [0-100]: ");
            strNum3 = Console.ReadLine();

            Console.Write("Enter your final exam grade [0-100]: ");
            strNum4 = Console.ReadLine();

            intNum1 = Convert.ToInt32(strNum1);
            intNum2 = Convert.ToInt32(strNum2);
            intNum3 = Convert.ToInt32(strNum3);
            intNum4 = Convert.ToInt32(strNum4);

            finalGrade = hwFinal + partFinal + quizFinal + examFinal

            if (finalGrade >= 90);
            {
                Console.WriteLine("\n\nYou received an A! Your final grade is {finalGrade}")

            }

            else if (finalGrade >= 80 and < 90);
            {
                Console.WriteLine("\n\nYou received a B! Your final grade is {finalGrade}")

            }

            else if (finalGrade >= 70 and < 80);
            {
                Console.WriteLine("\n\nYou received a C! Your final grade is {finalGrade}")

            }

            else if (finalGrade >= 60 and < 70);
            {
                Console.WriteLine("\n\nYou received a D! Your final grade is {finalGrade}")

            }

            else if (finalGrade < 60);
            {
                Console.WriteLine("\n\nYou did not pass the class, Your final grade is {finalGrade}")

            }









        }
    }
}
