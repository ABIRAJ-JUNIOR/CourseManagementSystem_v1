using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
    internal class CourseManager
    {
        private readonly List<Course> courses = new List<Course>();

        public void CreateCourse(string id,string title, string duration ,decimal price)
        {
            var course = new Course(id,title,duration,price);
            courses.Add(course);

            Console.WriteLine("Course added successfully.");
        }

        public void ReadCourses()
        {
            if (courses.Count != 0)
            {
                Console.WriteLine("--- List of Courses ---");
                foreach (var course in courses)
                {
                    Console.WriteLine($"ID: {course.GetCourseId()}, Title: {course.GetTitle()}, Duration: {course.GetDuration()}, Price: {course.GetPrice()}");
                }
            }
            else
            {
                Console.WriteLine("Course Not Available..");
            }
        }

        public void UpdateCourse(string id , string title, string duration, decimal price)
        {
            var course = courses.SingleOrDefault(s => s.GetCourseId() == id);
            if(course != null)
            {
                course.SetTitle(title);
                course.SetDuration(duration);
                course.SetPrice(price);

                Console.WriteLine("Course updated successfully.");
            }
            else
            {
                Console.WriteLine("Course Not Found..");
            }
        }
    }
}
