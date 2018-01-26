using System;
namespace CourseRegistrationManagementSystem.Models
{
    public class CourseAttribute
    {
        public CourseAttribute()
        {

        }

        public CourseAttribute(int iD, string name)
        {
            ID = iD;
            Name = name;
        }

        public int ID { get; set; }
        public string Name { get; set; }
    }
}
