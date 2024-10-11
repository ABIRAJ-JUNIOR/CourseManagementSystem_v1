using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
    internal class OnPremisCourse:Course
    {
        public string Schedule { get; set; }
        public int ClassroomCapacity { get; set; }

        public string DisplayOnPremisCourseInfo()
        {
            return base.ToString() + $"Schedule: {Schedule} , ClassroomCapacity: {ClassroomCapacity}";
        }
    }
}
