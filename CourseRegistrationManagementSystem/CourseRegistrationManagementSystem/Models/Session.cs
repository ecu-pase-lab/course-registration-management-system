using System;
namespace CourseRegistrationManagementSystem.Models
{
    public class Session
    {
        public Session()
        {

        }

        public Session(int iD, string name)
        {
            ID = iD;
            Name = name;
        }

        public int ID { get; set; }
        public string Name { get; set; }
    }
}
