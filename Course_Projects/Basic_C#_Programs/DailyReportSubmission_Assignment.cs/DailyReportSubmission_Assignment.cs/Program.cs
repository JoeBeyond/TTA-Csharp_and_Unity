using System;

namespace DailyReportSubmission_Assignment.cs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("b.:. Student Daily Report .:.d");
            Console.WriteLine("PRESS ENTER TO CONTINUE");
            Console.ReadLine();

            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("Great to see you again, " + userName + "!");

            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("You are on the " + courseName + " course, NICE!");

            Console.WriteLine("What page number?");
            string coursePageNum1 = Console.ReadLine();
            int coursePageNum2 = Convert.ToInt32(coursePageNum1);
            int page = coursePageNum2;
            Console.WriteLine("Your position in the above course is page " + page);

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            bool nh1 = true;
            string needHelp1 = Console.ReadLine();
            bool needHelp2 = Convert.ToBoolean(needHelp1);
            Console.WriteLine(needHelp2 == nh1);
            Console.WriteLine("OK!");
            Console.ReadLine();
            

            Console.WriteLine("Was there any positive experiences you would like to share? Please give specifics.");
            string experience = Console.ReadLine();
            Console.WriteLine("Thank you for sharing.");
            Console.ReadLine();

            Console.WriteLine("Is there any other feedback you would like to give? Please give specifics.");
            string feedback = Console.ReadLine();
            Console.WriteLine("Thank you for your feedback.");
            Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string hours1 = Console.ReadLine();
            int hours2 = Convert.ToInt32(hours1);
            int hoursStudent = hours2;
            Console.WriteLine("Excellent! " + hoursStudent + " hours is good!");
            Console.ReadLine();
        }
    }
}
