/**
 * Copyright 2018
 * James Adams IV
 * East Carolina University
 */

using System;
namespace CourseRegistrationManagementSystem.Models
{
    public class ScheduledCourse
    {
        public ScheduledCourse()
        {
            
        }

        public int ID { get; set; }
        public string ClassName { get; set; }
        public string ClassTime { get; set; }
        public string ClassroomName { get; set; }
        public double ClassroomLatitude { get; set; }
        public double ClassroomLongitude { get; set; }
    }
}
