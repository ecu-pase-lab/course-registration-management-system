using System;
namespace CourseRegistrationManagementSystem.Models
{
    public class Subject
    {
        public Subject()
        {

        }

        public Subject(int iD, string name)
        {
            ID = iD;
            Name = name;
        }

        public int ID { get; set; }
        public string Name { get; set; }
    }
}
