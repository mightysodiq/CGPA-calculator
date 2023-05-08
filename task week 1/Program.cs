using System;
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
        int    totalcourseunit = 0;
        // string remarks;
        int score;
        public void DataCollection()
        {
            Console.WriteLine("How many courses do you want to check ?");
            int input = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                Console.WriteLine("enter course code");
                courseCode = Console.ReadLine();

                Console.WriteLine(" input courseUnit");
                courseUnit = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter your score");
                score= Convert.ToInt32(Console.ReadLine());

                    if (score > 69 && score <= 100)
                    {
                    grade = 'A'; gradeUnit = 5; remarks = "Excellent"; weightpt = courseUnit * gradeUnit;
                    }
                    else if (score > 59 && score < 70)
                    {
                    grade = 'B'; gradeUnit = 4; remarks = "Very Good"; weightpt = courseUnit*gradeUnit;
                    }
                    else if (score > 49 && score <= 59)
                    {
                    grade = 'C'; gradeUnit = 3; remarks = "Good"; weightpt = courseUnit * gradeUnit;
                    }
                    else if (score > 44 && score <= 49)
                    {
                    grade = 'D'; gradeUnit =2; remarks = "Fair"; weightpt = courseUnit * gradeUnit;
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
                totalcourseunit += courseUnit;
                print = print + $"  {courseCode,-14} {courseUnit,-10} {grade,-10} {gradeUnit,-10} {weightpt,-1}  {remarks} \n";      
            }
            Console.WriteLine("|------------|-----------|------|----------|---------|----------|");
            Console.WriteLine("|course code |course unit|grade |grade unit|weight pt| remark   |");
            Console.WriteLine("|------------|-----------|------|----------|---------|----------|");
            Console.WriteLine (print);

            Console.WriteLine ("Total course Unit =" + totalcourseunit);
        }
        public static void Main(String  [] args)
        {

            //{
            // Console.WriteLine("|------------|-----------|------|----------|---------|-------|");
            //Console.WriteLine("|course code |course unit|grade |grade unit|weight pt| remark|");
            //Console.WriteLine("|------------|-----------|------|----------|---------|-------|");
            //Console.WriteLine(); }

            Program mySolutoin = new();
            mySolutoin.DataCollection();
        }

        
    }
}