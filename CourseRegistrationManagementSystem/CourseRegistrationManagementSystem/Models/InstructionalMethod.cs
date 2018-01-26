using System;
namespace CourseRegistrationManagementSystem.Models
{
    public class InstructionalMethod
    {
        public InstructionalMethod()
        {

        }

        public InstructionalMethod(int iD, string name)
        {
            ID = iD;
            Name = name;
        }

        public int ID { get; set; }
        public string Name { get; set; }
    }
}
