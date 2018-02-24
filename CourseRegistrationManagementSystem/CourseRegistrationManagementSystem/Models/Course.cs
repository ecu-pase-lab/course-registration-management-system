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
        public string Subject { get; set; }
        public DateTime RegistrationStartDate { get; set; }
        public DateTime RegistrationEndDate { get; set; }
        public DateTime ClassStartDate { get; set; }
        public DateTime ClassEndDate { get; set; }
        public List<string> CourseLevels { get; set; } 
        public string ClassInstructionalMethod { get; set; }
        public double CreditHours { get; set; }
        public string CourseTerm { get; set; }
        public List<string> ClassTimes { get; set; }
        public List<string> ClassDays { get; set; }
        public string CampusName { get; set; }
        public List<string> ClassroomName { get; set; }
        public string InstructorName { get; set; }
        public Seat CourseSeat { get; set; }
        public string Prerequisites { get; set; }
        public string TextbookName { get; set; }
        public double TextbookNewPrice { get; set; }
        public double TextbookUsedPrice { get; set; }
    }
}
