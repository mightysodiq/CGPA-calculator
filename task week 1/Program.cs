using System;
using System.ComponentModel.Design;
using System.Security.Cryptography;
using System.Xml.Schema;
/// using System.Runtime.InteropServices;

namespace task
{
    class Program
    {
        string courseCode;
        int courseUnit;
        char grade;
        int gradeUnit;
        int weightpt;
        string remarks;
        string print = "";
        int input;
        int totalcourseunitregistered = 0;
        int totalcourseunitpassed = 0;
        int totalweightpoint = 0;
        double GPA = 0;
        int score;


        public void DataCollection()
        {
            try {

                Console.WriteLine("How many courses do you want to check ?");
                input = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < input; i++)
                {
                    Console.WriteLine("enter course code");
                    courseCode = Console.ReadLine();

                    Console.WriteLine(" input courseUnit");
                    courseUnit = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("enter your score");
                    score = Convert.ToInt32(Console.ReadLine());

                    if (score > 69 && score <= 100)
                    {
                        grade = 'A'; gradeUnit = 5; remarks = "Excellent"; weightpt = courseUnit * gradeUnit;
                    }
                    else if (score > 59 && score < 70)
                    {
                        grade = 'B'; gradeUnit = 4; remarks = "Very Good"; weightpt = courseUnit * gradeUnit;
                    }
                    else if (score > 49 && score <= 59)
                    {
                        grade = 'C'; gradeUnit = 3; remarks = "Good"; weightpt = courseUnit * gradeUnit;
                    }
                    else if (score > 44 && score <= 49)
                    {
                        grade = 'D'; gradeUnit = 2; remarks = "Fair"; weightpt = courseUnit * gradeUnit;
                    }
                    else if (score > 39 && score <= 44)
                    {
                        grade = 'E'; gradeUnit = 1; remarks = "pass"; weightpt = courseUnit * gradeUnit;
                    }
                    else if (score >= 0 && score <= 39)
                    {
                        grade = 'F'; gradeUnit = 1; remarks = "fail"; weightpt = courseUnit * gradeUnit;
                    }
                    else
                    {
                        Console.WriteLine("your Input is invalid");
                        break;
                    }

                    totalweightpoint += weightpt;
                    totalcourseunitregistered += courseUnit;
                    if (grade != 'F')
                    {
                        totalcourseunitpassed += courseUnit;
                    }
                    print = print + $"|  {courseCode,-9} |{courseUnit,-10} |{grade,-5} |{gradeUnit,-9} |{weightpt,-8}  |{remarks,-10}| \n";
                }
                GPA = totalweightpoint / totalcourseunitregistered;
                Console.WriteLine("|------------|-----------|------|----------|----------|----------|");
                Console.WriteLine("|course code |course unit|grade |grade unit|weight pt | remark   |");
                Console.WriteLine("|------------|-----------|------|----------|----------|----------|");
                Console.Write(print);
                Console.WriteLine("|------------|-----------|------|----------|----------|----------|");

                Console.WriteLine("Total course Unit registered=" + totalcourseunitregistered);
                Console.WriteLine("total course unit passed=" + totalcourseunitpassed);
                Console.WriteLine("total weight point=" + totalweightpoint);
                Console.WriteLine($"your GPA = {GPA:F2}");
                Console.ReadKey();
            }
            catch(Exception e){ Console.WriteLine(e.Message);}

    }

    
   

    }
    class Program_run
    {
        static void Main(string[] args)
        {

            var obj =new Program();
            obj.DataCollection();

        }
    }
    
}


