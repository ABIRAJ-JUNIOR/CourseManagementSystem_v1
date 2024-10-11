using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
    internal class Course
    {
        private string CourseId;
        private string Title;
        private string Duration;
        private decimal Price;

        public static int TotalCourse = 0;
     
        public Course(string courseId, string title, string duration, decimal price)
        {
            CourseId = courseId;
            Title = title;
            Duration = duration;
            Price = price;
            TotalCourse++;

        }
        public Course()
        {
        }

        public void SetCourseId(string courseId)
        {
            this.CourseId = courseId;
        }

        public void SetTitle(string title) 
        { 
            this.Title = title; 
        }

        public void SetDuration(string duration)
        {
            this.Duration = duration;
        }

        public void SetPrice(decimal price)
        {
            this.Price = price; 
        }

        public string GetCourseId()
        {
            var id = this.CourseId;
            return id;
        }
        public string GetTitle()
        {
            var title = this.Title;
            return title;
        }
        public string GetDuration()
        {
            var duration = this.Duration;
            return duration;
        }
        public decimal GetPrice()
        {
            var price = this.Price;
            return price;
        }

        public override string ToString()
        {
            return $"ID: {CourseId}, Title: {Title}, Duration: {Duration}, Price: {Price}";
        }

        public virtual string DisplayCourseInfo()
        {
            return $"ID: {CourseId}, Title: {Title}, Duration: {Duration}, Price: {Price}";
        }
    }
}
