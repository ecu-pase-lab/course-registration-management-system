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
        public string CourseSubjectCode { get; set; }
        public string CourseRegistarCode { get; set; }
        public string SectionNumber { get; set; }
        public DateTime RegistrationStartDate { get; set; }
        public DateTime RegistrationEndDate { get; set; }
        public DateTime ClassStartDate { get; set; }
        public DateTime ClassEndDate { get; set; }
        public List<string> CourseLevels { get; set; } 
        public string ClassInstructionalMethod { get; set; }
        public double CreditHours { get; set; }
        public string CourseTerm { get; set; }
        public string ClassTimes { get; set; }
        public string ClassDays { get; set; }
        public string CampusName { get; set; }
        public string ClassroomName { get; set; }
        public string InstructorName { get; set; }
        public string TextbookName { get; set; }
        public double TextbookPrice { get; set; }
    }
}
