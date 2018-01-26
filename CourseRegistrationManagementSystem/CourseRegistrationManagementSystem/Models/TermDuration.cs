using System;
namespace CourseRegistrationManagementSystem.Models
{
    public class TermDuration
    {
        public TermDuration()
        {

        }

        public TermDuration(int iD, string name)
        {
            ID = iD;
            Name = name;
        }

        public int ID { get; set; }
        public string Name { get; set; }
    }
}
