using System;
namespace CourseRegistrationManagementSystem.Models
{
    public class Seat
    {
        public Seat()
        {

        }

        public int ID { get; set; }
        public int Capacity { get; set; }
        public int Actual { get; set; }
        public int Remaining { get; set; }
        public int WaitlistCapacity { get; set; }
        public int WaitlistActual { get; set; }
        public int WaitlistRemaining { get; set; }
    }
}
