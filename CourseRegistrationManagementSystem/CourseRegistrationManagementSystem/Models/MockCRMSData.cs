using System;
using System.Collections.Generic;
using CourseRegistrationManagementSystem.Models;

namespace CourseRegistrationManagementSystem.Controllers
{
    public class MockCRMSData
    {
        public MockCRMSData()
        {
            
        }

        public Dictionary<int, string> PopulateSemesters()
        {
            Dictionary<int, string> semesters = new Dictionary<int, string>();

            semesters.Add(1, "Spring 2018 (View Only)");
            semesters.Add(2, "Spring-Medical 2018 (View Only)");

            return semesters;
        }

        public Dictionary<int, string> PopulateSubjects()
        {
            Dictionary<int, string> subjects = new Dictionary<int, string>();

            subjects.Add(1, "All");
            subjects.Add(2, "Computer Science");
            subjects.Add(3, "English");
            subjects.Add(4, "Mathematics");
            subjects.Add(5, "Physics");
            subjects.Add(6, "Software Engineering");
            subjects.Add(7, "Spanish");

            return subjects;
        }

        public Dictionary<int, string> PopulateScheduleTypes()
        {
            Dictionary<int, string> scheduleTypes = new Dictionary<int, string>();

            scheduleTypes.Add(1, "All");
            scheduleTypes.Add(2, "Clinical");
            scheduleTypes.Add(3, "Colloquia");
            scheduleTypes.Add(4, "Honors (DO NOT USE)");

            return scheduleTypes;
        }

        public Dictionary<int, string> PopulateInstructionalMethods()
        {
            Dictionary<int, string> instructionalMethods = new Dictionary<int, string>();

            instructionalMethods.Add(1, "All");
            instructionalMethods.Add(2, "Face to Face");
            instructionalMethods.Add(3, "Face to Face Remote Site");
            instructionalMethods.Add(4, "Hybrid Primarily Face to Face");

            return instructionalMethods;
        }


        public Dictionary<int, string> PopulateCampuses()
        {
            Dictionary<int, string> campuses = new Dictionary<int, string>();

            campuses.Add(1, "All");
            campuses.Add(2, "DE/Internet");
            campuses.Add(3, "Main Campus");

            return campuses;
        }

        public Dictionary<int, string> PopulateCourseLevels()
        {
            Dictionary<int, string> courseLevels = new Dictionary<int, string>();

            courseLevels.Add(1, "All");
            courseLevels.Add(2, "Dental");
            courseLevels.Add(3, "Graduate");
            courseLevels.Add(4, "Professional (Doctorate/CAS)");
            courseLevels.Add(5, "Undergraduate");

            return courseLevels;
        }

        public Dictionary<int, string> PopulateTermDurations()
        {
            Dictionary<int, string> termDurations = new Dictionary<int, string>();

            termDurations.Add(1, "All");
            termDurations.Add(2, "Full Term");

            return termDurations;
        }

        public Dictionary<int, string> PopulateInstructors()
        {
            Dictionary<int, string> instructors = new Dictionary<int, string>();

            instructors.Add(1, "Ding, Junhua");
            instructors.Add(2, "Hills, Mark");
            instructors.Add(3, "Nassehzadeh-Tabrizi, Moha");
            instructors.Add(4, "Vilkomir, Sergiy");

            return instructors;
        }

        public Dictionary<int, string> PopulateSessions()
        {
            Dictionary<int, string> sessions = new Dictionary<int, string>();

            sessions.Add(1, "All");
            sessions.Add(2, "Field-Based Course Eval");
            sessions.Add(3, "Lab-Based Course Eval");
            sessions.Add(4, "Not to be Surveyed Course Eval");

            return sessions;
        }

        public Dictionary<int, string> PopulateCourseAttributes()
        {
            Dictionary<int, string> courseAttributes = new Dictionary<int, string>();

            courseAttributes.Add(1, "All");
            courseAttributes.Add(2, "AR-Special Music Fees");
            courseAttributes.Add(3, "Bassoon");
            courseAttributes.Add(4, "Cello");
            courseAttributes.Add(5, "Clarinet");

            return courseAttributes;
        }

        public List<Course> PopulateCourses()
        {
            Seat seat1 = new Seat();
            seat1.Capacity = 30;
            seat1.Actual = 8;
            seat1.Remaining = seat1.Capacity - seat1.Actual;
            seat1.WaitlistCapacity = 10;
            seat1.WaitlistActual = 0;
            seat1.WaitlistRemaining = seat1.WaitlistCapacity - seat1.WaitlistActual;

            Course course1 = new Course
            {
                ID = 1,
                CourseName = "Software Construction",
                CourseRegistarCode = "32329",
                CourseSubjectCode = "SENG 6245",
                SectionNumber = "001",
                CourseTerm = "Spring 2018",
                RegistrationStartDate = new DateTime(2017, 11, 3),
                RegistrationEndDate = new DateTime(2018, 1, 12),
                ClassStartDate = new DateTime(2018, 1, 8),
                ClassEndDate = new DateTime(2018, 5, 3),
                ClassInstructionalMethod = "Face to Face",
                CreditHours = 3,
                InstructorName = "Mark Hills (P)",
                ClassroomName = "Brewster Building 0B204",
                CampusName = "Main Campus",
                ClassDays = "Monday,Wednesday",
                ClassTimes = "2:00 pm - 3:15 pm",
                CourseSeat = seat1,
                Prerequisites = "Graduate level SENG 6230 Minimum Grade of C or Graduate level CSCI 6230 Minimum Grade of C",
                TextbookName = "Software Design",
                TextbookPrice = 80.00,
                CourseLevels = new List<string>{
                    "Graduate",
                    "Professional (Doctorate/CAS)"
                }

            };

            Seat seat2 = new Seat();
            seat2.Capacity = 30;
            seat2.Actual = 11;
            seat2.Remaining = seat2.Capacity - seat2.Actual;
            seat2.WaitlistCapacity = 10;
            seat2.WaitlistActual = 0;
            seat2.WaitlistRemaining = seat2.WaitlistCapacity - seat2.WaitlistActual;

            Course course2 = new Course
            {
                ID = 2,
                CourseName = "Software Requirements Engineering",
                CourseRegistarCode = "32332",
                CourseSubjectCode = "SENG 6255",
                SectionNumber = "601",
                CourseTerm = "Spring 2018",
                RegistrationStartDate = new DateTime(2017, 11, 3),
                RegistrationEndDate = new DateTime(2018, 1, 12),
                ClassStartDate = new DateTime(2018, 1, 8),
                ClassEndDate = new DateTime(2018, 5, 3),
                ClassInstructionalMethod = "Internet or World Wide Web",
                CreditHours = 3,
                InstructorName = "Sergiy Vilkomir (P)",
                ClassroomName = "N/A",
                CampusName = "De/Internet Campus",
                ClassDays = "Monday,Wednesday",
                ClassTimes = "12:30 pm - 1:45 pm",
                CourseSeat = seat2,
                Prerequisites = "",
                TextbookName = "Software Requirements",
                TextbookPrice = 120.00,
                CourseLevels = new List<string>{
                    "Graduate",
                    "Professional (Doctorate/CAS)"
                }

            };

            List<Course> courses = new List<Course>
            {
                course1,
                course2
            };

            return courses;
        }
    }
}
