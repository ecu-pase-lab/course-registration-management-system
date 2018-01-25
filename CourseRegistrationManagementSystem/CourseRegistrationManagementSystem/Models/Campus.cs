using System;
namespace CourseRegistrationManagementSystem.Models
{
    public class Campus
    {
        public Campus()
        {

        }

        public Campus(int iD, string name)
        {
            ID = iD;
            Name = name;
        }

        public int ID { get; set; }
        public string Name { get; set; }
    }
}
