using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var course = new Course();
            //course.SetCourseId("C_001");
            //course.SetTitle("python for beginers");
            //course.SetDuration("3 months");
            //course.SetPrice(10);

            //course.GetCourseId();
            //course.ToString();
            //Console.ReadKey();


            bool exit = true;
            while (exit)
            {
                Console.Clear();
                Console.WriteLine("--- Course Management System ---");
                Console.WriteLine("1. Add a Course");
                Console.WriteLine("2. View All Courses");
                Console.WriteLine("3. Update a Courses");
                Console.WriteLine("4. Delete a Course");
                Console.WriteLine("5. Exit");
                Console.Write("\nChoose an Option : ");
                string option = Console.ReadLine();

                switch(option)
                {
                    case "1":
                        Console.Clear();
                        break;
                    case "2":
                        Console.Clear();
                        break;
                    case "3":
                        Console.Clear();
                        break;
                    case "4":
                        Console.Clear();
                        break;
                    case "5":
                        exit = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }

                if(option != "5")
                {
                    Console.WriteLine("Press any Key to Continue..");
                    Console.ReadKey();
                }

            }
        }
    }
}
