using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_oquendo
{
    class Program
    {
        static void Pause()
        {
            Console.WriteLine("\n\nPress any key to continue..");
            Console.ReadKey();
        }

        static String calcGrade(Double labAvg, String letGrade, List <String> letter)
        {
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

            else
            {
                letGrade = "F";
            }

            return letGrade;

        }

        static void calcClass(ref Double classavg, Double numberGrade1, Double numberGrade2, Double numberGrade3, Double numberGrade4, Double numberGrade5)
        {
            classavg = (numberGrade1 + numberGrade2 + numberGrade3 + numberGrade4 + numberGrade5) / 5;
        }
            

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

            Double labAvg, numberGrade1 = 0, numberGrade2 = 0, numberGrade3 = 0, numberGrade4 = 0, numberGrade5 = 0;
            Double classavg = 0, dbltemp, totalStudents = 0, totalgrade = 0;
            String strFname, strLname, letGrade = "F";
            String temp;
            bool bln;

            List<String> fnames = new List<String>();
            List<String> lnames = new List<String>();
            List<String> letter = new List<String>();
            List<Double> lablist1 = new List<Double>();
            List<Double> lablist2 = new List<Double>();
            List<Double> lablist3 = new List<Double>();
            List<Double> lablist4 = new List<Double>();
            List<Double> lablist5 = new List<Double>();
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
                totalgrade = 0;

                Console.Write("Please enter student's first name: ");
                strFname = Console.ReadLine();
                fnames.Add(strFname);

                Console.Write("Please enter student's last name: ");
                strLname = Console.ReadLine();
                lnames.Add(strLname);

                for (int x = 0; x < 5; x++)
                {
                    do
                    {
                        Console.Write($"Enter your grade for Lab #{x} [0-100]: ");
                        temp = Console.ReadLine();
                        bln = Double.TryParse(temp, out dbltemp);
                        if (bln == false)
                        {
                            Console.Write("Error - Please enter a valid number from 0-100: ");
                        }

                    } while (bln == false);

                    totalgrade += dbltemp;

                    switch (x)
                    {
                        case 0:
                            lablist1.Add(dbltemp);
                            numberGrade1 += dbltemp;
                            break;
                        case 1:
                            lablist2.Add(dbltemp);
                            numberGrade2 += dbltemp;
                            break;
                        case 2:
                            lablist3.Add(dbltemp);
                            numberGrade3 += dbltemp;
                            break;
                        case 3:
                            lablist4.Add(dbltemp);
                            numberGrade4 += dbltemp;
                            break;
                        case 4:
                            lablist5.Add(dbltemp);
                            numberGrade5 += dbltemp;
                            break;

                    }

                }

                labAvg = totalgrade / 5;
                studentsAvg.Add(labAvg);

                letGrade =  calcGrade(labAvg, letGrade, letter);
                letter.Add(letGrade);

            }

            numberGrade1 /= totalStudents;
            numberGrade2 /= totalStudents;
            numberGrade3 /= totalStudents;
            numberGrade4 /= totalStudents;
            numberGrade5 /= totalStudents;

            calcClass(ref classavg, numberGrade1, numberGrade2, numberGrade3, numberGrade4, numberGrade5);

            Console.WriteLine("Name\t\t\t\t" + "Lab1   " + "Lab2   " + "Lab3   " + "Lab4  " + "Lab5  " + " Grade");

            for (int i = 0; i < totalStudents; i++)
            {

                Console.WriteLine(String.Format("{0,12} {1,12}     {2,5}  {3,5}  {4,5}  {5,5} {6,5}\t   {7:0.0} - {8,2}", fnames[i], lnames[i] , lablist1[i], lablist2[i], lablist3[i], lablist4[i], lablist5[i], studentsAvg[i], letter[i]));

            }

            Console.WriteLine(String.Format("Class Average:\t\t\t{0:0.0}   {1:0.0}   {2:0.0}   {3:0.0}  {4:0.0}    {5:0.0}", numberGrade1, numberGrade2, numberGrade3, numberGrade4, numberGrade5, classavg));

            Pause();










        }
    }
}
