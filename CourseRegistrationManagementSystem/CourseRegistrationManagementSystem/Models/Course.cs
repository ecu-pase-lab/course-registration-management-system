using System;
using System.Collections.Generic;

namespace CourseRegistrationManagementSystem.Models
{
    public class Course
    {
        public Course()
        {

        }

        public int ID { get; set; }
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public string SectionNumber { get; set; }
        public Dictionary<DayOfWeek, TimeSpan> ClassTimes { get; set; }
        public string BuildingName { get; set; }
        public string InstructorName { get; set; }
        public string TextbookName { get; set; }
        public string TextbookPrice { get; set; }
    }
}
