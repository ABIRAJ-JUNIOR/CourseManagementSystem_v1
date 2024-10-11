using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
    internal class Course
    {
        private string CourseId { get; set; }
        private string Title { get; set; }
        private string Duration { get; set; }
        private decimal Price { get; set; }

        public Course()
        {
        }

        public Course(string courseId, string title, string duration, decimal price)
        {
            CourseId = courseId;
            Title = title;
            Duration = duration;
            Price = price;
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
            return $"ID: {this.GetCourseId()}, Title: {this.GetTitle()}, Duration: {this.GetDuration()}, Price: {this.GetPrice()}";
        }
    }
}
