using System;
namespace CourseRegistrationManagementSystem.Models
{
    public class Instructor
    {
        public Instructor()
        {

        }

        public Instructor(int iD, string name)
        {
            ID = iD;
            Name = name;
        }

        public int ID { get; set; }
        public string Name { get; set; }
    }
}
