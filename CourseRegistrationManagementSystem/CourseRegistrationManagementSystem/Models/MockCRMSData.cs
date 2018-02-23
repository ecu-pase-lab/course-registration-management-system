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
            subjects.Add(2, "Communication");
            subjects.Add(3, "Computer Science");
            subjects.Add(4, "Mathematics");
            subjects.Add(5, "Physics");
            subjects.Add(6, "Software Engineering");

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

            //Software Engineering and Computer Science
            instructors.Add(1, "Ding, Junhua");
            instructors.Add(2, "Hills, Mark");
            instructors.Add(3, "Nassehzadeh-Tabrizi, Moha");
            instructors.Add(4, "Vilkomir, Sergiy");
            instructors.Add(5, "Robert Dancy Hoggard");
            instructors.Add(6, "Krishnan Gopalakrishnan");
            instructors.Add(7, "Qin Ding");

            //Communication 
            instructors.Add(8, "Kelsey Elisabeth Rhodes");
            instructors.Add(9, "Daniel Addison Wiseman");
            instructors.Add(10, "Pamela Davis Hopkins"); 

            //Mathematics
            instructors.Add(11, "Johannes Hendrik Hattingh");
            instructors.Add(12, "Heather Dawn Ries");
            instructors.Add(13, "Gail L Ratcliff"); 
            instructors.Add(14, "Wayne L Tabor");
            instructors.Add(15, "Ronald L Williams"); 

            //Physics
            instructors.Add(16, "Regina DeWitt, Wilson Hawkins");
            instructors.Add(17, "Gregory Lapicki");

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
                InstructorName = "Mark Hills",
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
                InstructorName = "Sergiy Vilkomir",
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

            Seat seat3 = new Seat();
            seat3.Capacity = 30;
            seat3.Actual = 22;
            seat3.Remaining = seat3.Capacity - seat3.Actual;
            seat3.WaitlistCapacity = 10;
            seat3.WaitlistActual = 0;
            seat3.WaitlistRemaining = seat3.WaitlistCapacity - seat3.WaitlistActual;

            Course course3 = new Course
            {
                ID = 3,
                CourseName = "Software Engineering Foundations",
                CourseRegistarCode = "85697",
                CourseSubjectCode = "SENG 6230",
                SectionNumber = "001",
                CourseTerm = "Spring 2018",
                RegistrationStartDate = new DateTime(2017, 11, 3),
                RegistrationEndDate = new DateTime(2018, 1, 12),
                ClassStartDate = new DateTime(2018, 1, 8),
                ClassEndDate = new DateTime(2018, 5, 3),
                ClassInstructionalMethod = "Face to Face",
                CreditHours = 3,
                InstructorName = "Moha Nassehzadeh-Tabrizi",
                ClassroomName = "Brewster Building 0B203",
                CampusName = "Main Campus",
                ClassDays = "Tuesday,Thursday",
                ClassTimes = "11:00 am - 12:15 pm",
                CourseSeat = seat3,
                Prerequisites = "",
                TextbookName = "Software Foundations",
                TextbookPrice = 100.00,
                CourseLevels = new List<string>{
                    "Graduate"
                }

            };

            Seat seat4 = new Seat();
            seat4.Capacity = 30;
            seat4.Actual = 5;
            seat4.Remaining = seat4.Capacity - seat4.Actual;
            seat4.WaitlistCapacity = 10;
            seat4.WaitlistActual = 0;
            seat4.WaitlistRemaining = seat4.WaitlistCapacity - seat4.WaitlistActual;

            Course course4 = new Course
            {
                ID = 4,
                CourseName = "Software Systems Modeling and Analysis",
                CourseRegistarCode = "85714",
                CourseSubjectCode = "SENG 6250",
                SectionNumber = "001",
                CourseTerm = "Spring 2018",
                RegistrationStartDate = new DateTime(2017, 11, 3),
                RegistrationEndDate = new DateTime(2018, 1, 12),
                ClassStartDate = new DateTime(2018, 1, 8),
                ClassEndDate = new DateTime(2018, 5, 3),
                ClassInstructionalMethod = "Face to Face",
                CreditHours = 3,
                InstructorName = "Junhua Ding",
                ClassroomName = "Joyner East 00214",
                CampusName = "Main Campus",
                ClassDays = "Tuesday,Thursday",
                ClassTimes = "2:00 pm - 3:15 pm",
                CourseSeat = seat4,
                Prerequisites = "Graduate level SENG 6230 Minimum Grade of C",
                TextbookName = "Modeling and Analysis",
                TextbookPrice = 80.00,
                CourseLevels = new List<string>{
                    "Graduate"
                }

            };

            Seat seat5 = new Seat();
            seat5.Capacity = 30;
            seat5.Actual = 14;
            seat5.Remaining = seat5.Capacity - seat5.Actual;
            seat5.WaitlistCapacity = 10;
            seat5.WaitlistActual = 0;
            seat5.WaitlistRemaining = seat5.WaitlistCapacity - seat5.WaitlistActual;

            Course course5 = new Course
            {
                ID = 5,
                CourseName = "Software Systems Modeling and Analysis",
                CourseRegistarCode = "85715",
                CourseSubjectCode = "SENG 6250",
                SectionNumber = "601",
                CourseTerm = "Spring 2018",
                RegistrationStartDate = new DateTime(2017, 11, 3),
                RegistrationEndDate = new DateTime(2018, 1, 12),
                ClassStartDate = new DateTime(2018, 1, 8),
                ClassEndDate = new DateTime(2018, 5, 3),
                ClassInstructionalMethod = "Internet or World Wide Web",
                CreditHours = 3,
                InstructorName = "Junhua Ding",
                ClassroomName = "N/A",
                CampusName = "De/Internet Campus",
                ClassDays = "Tuesday,Thursday",
                ClassTimes = "2:00 pm - 3:15 pm",
                CourseSeat = seat5,
                Prerequisites = "Graduate level SENG 6230 Minimum Grade of C",
                TextbookName = "Modeling and Analysis",
                TextbookPrice = 80.00,
                CourseLevels = new List<string>{
                    "Graduate"
                }

            };

            Seat seat6 = new Seat();
            seat6.Capacity = 160;
            seat6.Actual = 160;
            seat6.Remaining = seat6.Capacity - seat6.Actual;
            seat6.WaitlistCapacity = 10;
            seat6.WaitlistActual = 2;
            seat6.WaitlistRemaining = seat6.WaitlistCapacity - seat6.WaitlistActual;

            Course course6 = new Course
            {
                ID = 6,
                CourseName = "Algorithmic Problem Solving",
                CourseRegistarCode = "85586",
                CourseSubjectCode = "CSCI 1010",
                SectionNumber = "001",
                CourseTerm = "Spring 2018",
                RegistrationStartDate = new DateTime(2017, 11, 3),
                RegistrationEndDate = new DateTime(2018, 1, 12),
                ClassStartDate = new DateTime(2018, 1, 8),
                ClassEndDate = new DateTime(2018, 5, 3),
                ClassInstructionalMethod = "Face to Face",
                CreditHours = 3,
                InstructorName = "Robert Dancy Hoggard",
                ClassroomName = "Howell Science Complex C103B",
                CampusName = "Main Campus",
                ClassDays = "Monday,Wednesday,Friday",
                ClassTimes = "1:00 pm - 1:50 pm",
                CourseSeat = seat6,
                Prerequisites = "Undergraduate level MATH 1065 Minimum Grade of D- or Undergraduate level CSCI 1000 Minimum Grade of C",
                TextbookName = "Algorithms Handbook",
                TextbookPrice = 60.00,
                CourseLevels = new List<string>{
                    "Undergraduate"
                }

            };

            Seat seat7 = new Seat();
            seat7.Capacity = 24;
            seat7.Actual = 22;
            seat7.Remaining = seat7.Capacity - seat7.Actual;
            seat7.WaitlistCapacity = 10;
            seat7.WaitlistActual = 0;
            seat7.WaitlistRemaining = seat7.WaitlistCapacity - seat7.WaitlistActual;

            Course course7 = new Course
            {
                ID = 7,
                CourseName = "Algorithmic Problem Solving Lab",
                CourseRegistarCode = "85587",
                CourseSubjectCode = "CSCI 1011",
                SectionNumber = "001",
                CourseTerm = "Spring 2018",
                RegistrationStartDate = new DateTime(2017, 11, 3),
                RegistrationEndDate = new DateTime(2018, 1, 12),
                ClassStartDate = new DateTime(2018, 1, 8),
                ClassEndDate = new DateTime(2018, 5, 3),
                ClassInstructionalMethod = "Face to Face",
                CreditHours = 3,
                InstructorName = "Robert Dancy Hoggard",
                ClassroomName = "Bate Building 01025",
                CampusName = "Main Campus",
                ClassDays = "Monday",
                ClassTimes = "1:00 pm - 2:40 pm",
                CourseSeat = seat6,
                Prerequisites = "",
                TextbookName = "Algorithms Handbook",
                TextbookPrice = 60.00,
                CourseLevels = new List<string>{
                    "Undergraduate"
                }

            };

            Seat seat8 = new Seat();
            seat8.Capacity = 24;
            seat8.Actual = 20;
            seat8.Remaining = seat8.Capacity - seat8.Actual;
            seat8.WaitlistCapacity = 10;
            seat8.WaitlistActual = 0;
            seat8.WaitlistRemaining = seat8.WaitlistCapacity - seat8.WaitlistActual;

            Course course8 = new Course
            {
                ID = 8,
                CourseName = "Algorithmic Problem Solving Lab",
                CourseRegistarCode = "85588",
                CourseSubjectCode = "CSCI 1011",
                SectionNumber = "002",
                CourseTerm = "Spring 2018",
                RegistrationStartDate = new DateTime(2017, 11, 3),
                RegistrationEndDate = new DateTime(2018, 1, 12),
                ClassStartDate = new DateTime(2018, 1, 8),
                ClassEndDate = new DateTime(2018, 5, 3),
                ClassInstructionalMethod = "Face to Face",
                CreditHours = 3,
                InstructorName = "Robert Dancy Hoggard",
                ClassroomName = "Bate Building 01025",
                CampusName = "Main Campus",
                ClassDays = "Tuesday",
                ClassTimes = "2:30 pm - 4:10 pm",
                CourseSeat = seat8,
                Prerequisites = "",
                TextbookName = "Algorithms Handbook",
                TextbookPrice = 60.00,
                CourseLevels = new List<string>{
                    "Undergraduate"
                }

            };

            Seat seat9 = new Seat();
            seat9.Capacity = 30;
            seat9.Actual = 25;
            seat9.Remaining = seat9.Capacity - seat9.Actual;
            seat9.WaitlistCapacity = 10;
            seat9.WaitlistActual = 0;
            seat9.WaitlistRemaining = seat9.WaitlistCapacity - seat9.WaitlistActual;

            Course course9 = new Course
            {
                ID = 9,
                CourseName = "Discrete Structures I",
                CourseRegistarCode = "36952",
                CourseSubjectCode = "CSCI 2400",
                SectionNumber = "001",
                CourseTerm = "Spring 2018",
                RegistrationStartDate = new DateTime(2017, 11, 3),
                RegistrationEndDate = new DateTime(2018, 1, 12),
                ClassStartDate = new DateTime(2018, 1, 8),
                ClassEndDate = new DateTime(2018, 5, 3),
                ClassInstructionalMethod = "Face to Face",
                CreditHours = 3,
                InstructorName = "Krishnan Gopalakrishnan",
                ClassroomName = "Brewster Building 0B304",
                CampusName = "Main Campus",
                ClassDays = "Tuesday,Thursday",
                ClassTimes = "3:30 pm - 4:45 pm",
                CourseSeat = seat9,
                Prerequisites = "Undergraduate level MATH 1065 Minimum Grade of D-",
                TextbookName = "Foundations of Discrete Mathematics",
                TextbookPrice = 130.00,
                CourseLevels = new List<string>{
                    "Undergraduate"
                }

            };

            Seat seat10 = new Seat();
            seat10.Capacity = 50;
            seat10.Actual = 32;
            seat10.Remaining = seat10.Capacity - seat10.Actual;
            seat10.WaitlistCapacity = 10;
            seat10.WaitlistActual = 0;
            seat10.WaitlistRemaining = seat10.WaitlistCapacity - seat10.WaitlistActual;

            Course course10 = new Course
            {
                ID = 10,
                CourseName = "Data Abstraction and Object-Oriented Data Structures",
                CourseRegistarCode = "32228",
                CourseSubjectCode = "CSCI 2540",
                SectionNumber = "001",
                CourseTerm = "Spring 2018",
                RegistrationStartDate = new DateTime(2017, 11, 3),
                RegistrationEndDate = new DateTime(2018, 1, 12),
                ClassStartDate = new DateTime(2018, 1, 8),
                ClassEndDate = new DateTime(2018, 5, 3),
                ClassInstructionalMethod = "Face to Face",
                CreditHours = 3,
                InstructorName = "Qin Ding",
                ClassroomName = "Howell Science Complex 0N107",
                CampusName = "Main Campus",
                ClassDays = "Tuesday,Thursday",
                ClassTimes = "9:30 am - 10:45 am",
                CourseSeat = seat10,
                Prerequisites = "(Undergraduate level CSCI 2530 Minimum Grade of C or Undergraduate level CSCI 3300 Minimum Grade of C) and Undergraduate level CSCI 2405 Minimum Grade of C",
                TextbookName = "Object-Oriented Programming",
                TextbookPrice = 60.00,
                CourseLevels = new List<string>{
                    "Undergraduate"
                }

            };

            List<Course> courses = new List<Course>
            {
                course1,
                course2,
                course3,
                course4,
                course5,
                course6,
                course7,
                course8,
                course9,
                course10
            };

            return courses;
        }
    }
}
