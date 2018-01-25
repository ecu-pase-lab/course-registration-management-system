using System;
namespace CourseRegistrationManagementSystem.Models
{
    public class Semester
    {
        public Semester()
        {
            
        }

        public Semester(int iD, string name)
        {
            ID = iD;
            Name = name;
        }

        public int ID { get; set; }
        public string Name { get; set; }
    }
}
