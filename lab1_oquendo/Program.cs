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
            Int32 intNum1 = 0, intNum2 = 0, intNum3 = 0, intNum4 = 0;

            Double hwGrade = 0, hwFinal = 0, partGrade = 0, partFinal = 0, quizGrade = 0, quizFinal = 0, examGrade= 0, examFinal = 0, dblNum1 = 0, dblNum2 = 0, dblNum3;

            String strFirst, strNum1, strNum2, strNum3, strNum4;



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




            //partGrade = 25% of final grade
            quizFinal = quizGrade * .25

            //partGrade = 25% of final grade
            examFinal = examGrade * .25

            //partGrade = 20% of final grade
            partFinal = partGrade * .20

            //hwGrade = 20% of final grade
            hwFinal = hwGrade * .20

        }
    }
}
