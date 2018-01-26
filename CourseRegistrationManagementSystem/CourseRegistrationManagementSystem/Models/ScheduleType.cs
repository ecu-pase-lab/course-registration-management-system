using System;
namespace CourseRegistrationManagementSystem.Models
{
    public class ScheduleType
    {
        public ScheduleType()
        {

        }

        public ScheduleType(int iD, string name)
        {
            ID = iD;
            Name = name;
        }

        public int ID { get; set; }
        public string Name { get; set; }
    }
}
