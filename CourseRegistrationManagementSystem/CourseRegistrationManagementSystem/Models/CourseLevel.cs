using System;
namespace CourseRegistrationManagementSystem.Models
{
    public class CourseLevel
    {
        public CourseLevel()
        {

        }

        public CourseLevel(int iD, string name)
        {
            ID = iD;
            Name = name;
        }

        public int ID { get; set; }
        public string Name { get; set; }
    }
}
