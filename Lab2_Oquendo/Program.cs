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

            Int32 intLab1, intLab2, intLab3, intLab4, intLab5, totalStudents = 0;
            Double labAvg;
            String strFname, strLname, strLab1, strLab2, strLab3, strLab4, strLab5, letGrade = "F";

            List<String> fnames = new List<String>();
            List<String> lnames = new List<String>();
            List<String> letter = new List<String>();
            List<Int32> lablist1 = new List<Int32>();
            List<Int32> lablist2 = new List<Int32>();
            List<Int32> lablist3 = new List<Int32>();
            List<Int32> lablist4 = new List<Int32>();
            List<Int32> lablist5 = new List<Int32>();
            List<Double> studentsAvg = new List<Double>();
            List<Double> classAvg1 = new List<Double>();
            List<Double> classAvg2 = new List<Double>();
            List<Double> classAvg3 = new List<Double>();
            List<Double> classAvg4 = new List<Double>();
            List<Double> classAvg5 = new List<Double>();

            Console.Write("How many student records do we plan to process?: ");
            totalStudents = int.Parse(Console.ReadLine());

            for (int cntr = 1; cntr <= totalStudents; cntr++)
            {
                Console.Write("Please enter student's first name: ");
                strFname = Console.ReadLine();
                fnames.Add(strFname);

                Console.Write("Please enter student's last name: ");
                strLname = Console.ReadLine();
                lnames.Add(strLname);

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

                labAvg = (intLab1 + intLab2 + intLab3 + intLab4 + intLab5)/5;
                studentsAvg.Add(labAvg);

                if (labAvg >= 90)
                {
                    letGrade = "A";
                }
                
                else if (labAvg >= 80)
                {
                    letGrade = "B";
                }
                
                else if (labAvg >= 70)
                {
                    letGrade = "C";
                }
                
                else if (labAvg >= 60)
                {
                    letGrade = "D";
                }

                else if (labAvg < 60)
                {
                    letGrade = "F";
                }

                letter.Add(letGrade);
                
            }

            double lab1avg = (lablist1[0] + lablist1[1] + lablist1[2] + lablist1[3] + lablist1[4])/5;
            double lab2avg = (lablist2[0] + lablist2[1] + lablist2[2] + lablist2[3] + lablist2[4])/5;
            double lab3avg = (lablist3[0] + lablist3[1] + lablist3[2] + lablist3[3] + lablist3[4])/5;
            double lab4avg = (lablist4[0] + lablist4[1] + lablist4[2] + lablist4[3] + lablist4[4])/5;
            double lab5avg = (lablist5[0] + lablist5[1] + lablist5[2] + lablist5[3] + lablist5[4])/5;
            double classavg = (lab1avg + lab2avg + lab3avg + lab4avg + lab5avg)/5;

            Console.WriteLine("Name\t\t" + "Lab1   " + "Lab2   " + "Lab3   " + "Lab4  " + "Lab5  " + "Grade"));

            for (int i = 0; i < totalStudents; i++)
            {

                
                Console.WriteLine(fnames[i] + " " + lnames[i] + "\t\t" + lablist1[i] + "  " + lablist2[i] + "  " + lablist3[i] + "  " + lablist4[i] + "  " + lablist5[i] + "  " + studentsAvg[i] + "  " + letGrade[i]);

                

                Console.WriteLine("Class Average:\t" + lab1avg + "  " + lab2avg + "  " + lab3avg + "  " + lab4avg + "  " + lab5avg + "  " + classavg);

            }

            Console.WriteLine("\n\nPress any key to end the program..");
            Console.ReadKey();

        }
    }
}
