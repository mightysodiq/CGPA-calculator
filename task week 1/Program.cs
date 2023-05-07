using System;
using System.Runtime.InteropServices;

namespace task
{
    class program
        
    {
        static void Main(String[] args)
        {
            string  courseCode;
            int courseUnit; 
            char grade;
            int gradeUnit;
            int weightPoint;
            int weightpt;
            string remarks;
            int score;

            Console.WriteLine("How many courses do you want to check ?");
            string nuo = Console.ReadLine();
            int input =Convert.ToInt32(nuo);

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
                    grade = 'A';
                    gradeUnit = 5;
                    remarks = "Excellent";
                    weightPoint = courseUnit * gradeUnit;
                }
                else if( score>59 && score < 70 )
                {
                    grade = 'B';
                    gradeUnit = 4;
                    remarks = "very good";
                    weightPoint = courseUnit * gradeUnit;       
                }
                else if(score>49 && score <= 59)
                {
                    grade = 'C';
                    gradeUnit = 3;
                    remarks = "Good";
                    weightPoint = courseUnit * gradeUnit;
                }
                else if(score>44 && score<= 49)
                {
                    grade = 'D';
                    gradeUnit = 2;
                    remarks = "Fair";
                    weightPoint = courseUnit * gradeUnit;
                }
                else if (score>39 && score<= 44)
                {
                    grade = 'E';
                    gradeUnit = 1;
                    remarks = "pass";
                    weightPoint = courseUnit * gradeUnit;
                }
                else if (score>=0 && score<=39)
                {
                    grade = 'F';
                    gradeUnit = 0;
                    remarks = "fail";
                    weightPoint = courseUnit * gradeUnit;
                }
                else
                {
                    Console.WriteLine("your input is invalid");
                }
                   
            } 
           
        //{
           // Console.WriteLine("|------------|-----------|------|----------|---------|-------|");
            //Console.WriteLine("|course code |course unit|grade |grade unit|weight pt| remark|");
            //Console.WriteLine("|------------|-----------|------|----------|---------|-------|");
            //Console.WriteLine(); }

                
        }
    }
}