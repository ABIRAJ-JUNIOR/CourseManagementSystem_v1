using System;
using System.Collections.Generic;
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
    }
}
