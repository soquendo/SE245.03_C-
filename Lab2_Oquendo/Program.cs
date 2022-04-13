using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Oquendo
{
    class Program
    {
        static void Main(string[] args)
        {

            //For each student, enter a name and 5 lab grades.  Display each student with each average
            //grade for their 5 labs, and their letter grade.  Drop down a line or two, and then display
            //the average for each lab #.  (Average grade on Lab #1 for all students)

            //=========================================================================

            //
            //Declare lists, variables and class average for each lab
            //Create user inputs for student name along with five lab grades
            //Store the values in parallel lists
            //Calculate each student's total lab grade
            //Print number grade average and letter grade for each student
            //End prog

            Int32 intLab1, intLab2, intLab3, intLab4, intLab5;
        
            Double labGrade;

            String strName, strLab1, strLab2, strLab3, strLab4, strLab5;

            List<String> names = new List<String>();
            List<Int32> lablist1 = new List<Int32>();
            List<Int32> lablist2 = new List<Int32>();
            List<Int32> lablist3 = new List<Int32>();
            List<Int32> lablist4 = new List<Int32>();
            List<Int32> lablist5 = new List<Int32>();
            List<Double> studentAvg = new List<Double>();


            Console.Write("Please enter student name: ");
            strName = Console.ReadLine();
            names.Add(strName);

            Console.Write("Enter your grade for Lab #1 [0-100]: ");
            strLab1 = Console.ReadLine();
            intLab1 = Convert.ToInt32(strLab1);
            lablist1.Add(intLab1);

            Console.Write("Enter your grade for Lab #2 [0-100]: ");
            strLab2 = Console.ReadLine();
            intLab2 = Convert.ToInt32(strLab2);
            lablist2.Add(intLab2);

            Console.Write("Enter your grade for Lab #3 [0-100]: ");
            strLab3 = Console.ReadLine();
            intLab3 = Convert.ToInt32(strLab3);
            lablist3.Add(intLab3);

            Console.Write("Enter your grade for Lab #4 [0-100]: ");
            strLab4 = Console.ReadLine();
            intLab4 = Convert.ToInt32(strLab4);
            lablist4.Add(intLab4);

            Console.Write("Enter your grade for Lab #5 [0-100]: ");
            strLab5 = Console.ReadLine();
            intLab5 = Convert.ToInt32(strLab5);
            lablist5.Add(intLab5);

            labGrade = intLab1 + intLab2 + intLab3 + intLab4 + intLab5;

            


            if (finalGrade >= 90)
            {
                Console.WriteLine($"\n\nYou received an A! Your final grade is {finalGrade}");

            }

            else if (finalGrade >= 80)
            {
                Console.WriteLine($"\n\nYou received a B! Your final grade is {finalGrade}");

            }

            else if (finalGrade >= 70)
            {
                Console.WriteLine($"\n\nYou received a C! Your final grade is {finalGrade}");

            }

            else if (finalGrade >= 60)
            {
                Console.WriteLine($"\n\nYou received a D! Your final grade is {finalGrade}");

            }

            else if (finalGrade < 60)
            {
                Console.WriteLine($"\n\nYou did not pass the class, Your final grade is {finalGrade}");

            }


            Console.WriteLine("\n\nPress any key to continue..");
            Console.ReadKey();







        }
    }
}
