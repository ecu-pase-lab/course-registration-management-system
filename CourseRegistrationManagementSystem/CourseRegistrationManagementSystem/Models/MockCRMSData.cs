﻿using System;
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

            //Mathematics
            instructors.Add(10, "Johannes Hendrik Hattingh");
            instructors.Add(11, "Heather Dawn Ries");
            instructors.Add(12, "Gail L Ratcliff"); 
            instructors.Add(13, "Deborah K Ferrell");

            //Physics
            instructors.Add(14, "Regina DeWitt, Wilson Hawkins");

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
                Subject = "Software Engineering",
                CourseTerm = "Spring 2018",
                RegistrationStartDate = new DateTime(2017, 11, 3),
                RegistrationEndDate = new DateTime(2018, 1, 12),
                ClassStartDate = new DateTime(2018, 1, 8),
                ClassEndDate = new DateTime(2018, 5, 3),
                ClassInstructionalMethod = "Face to Face",
                CreditHours = 3,
                InstructorName = "Mark Hills",
                ClassroomName = new List<string>{
                    "Brewster Building 0B204"
                },
                CampusName = "Main Campus",
                ClassDays = new List<string>{
                    "Monday,Wednesday"
                },
                ClassTimes = new List<string>{
                    "2:00 pm - 3:15 pm"
                },
                CourseSeat = seat1,
                Prerequisites = "Graduate level SENG 6230 Minimum Grade of C or Graduate level CSCI 6230 Minimum Grade of C",
                TextbookName = "Program Development in Java, ISBN: 9780201657685, Author: Liskov",
                TextbookNewPrice = 100.00,
                TextbookUsedPrice = 75.00,
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
                Subject = "Software Engineering",
                CourseTerm = "Spring 2018",
                RegistrationStartDate = new DateTime(2017, 11, 3),
                RegistrationEndDate = new DateTime(2018, 1, 12),
                ClassStartDate = new DateTime(2018, 1, 8),
                ClassEndDate = new DateTime(2018, 5, 3),
                ClassInstructionalMethod = "Internet or World Wide Web",
                CreditHours = 3,
                InstructorName = "Sergiy Vilkomir",
                ClassroomName = new List<string>{
                    "N/A"
                },
                CampusName = "De/Internet Campus",
                ClassDays = new List<string>{
                    "Monday,Wednesday"
                },
                ClassTimes = new List<string>{
                    "12:30 pm - 1:45 pm"
                },
                CourseSeat = seat2,
                Prerequisites = "",
                TextbookName = "Requirements Engineering, ISBN: 9780470012703, Author: Van Lamsweerd",
                TextbookNewPrice = 87.00,
                TextbookUsedPrice = 65.25,
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
                Subject = "Software Engineering",
                CourseTerm = "Spring 2018",
                RegistrationStartDate = new DateTime(2017, 11, 3),
                RegistrationEndDate = new DateTime(2018, 1, 12),
                ClassStartDate = new DateTime(2018, 1, 8),
                ClassEndDate = new DateTime(2018, 5, 3),
                ClassInstructionalMethod = "Face to Face",
                CreditHours = 3,
                InstructorName = "Moha Nassehzadeh-Tabrizi",
                ClassroomName = new List<string>{
                    "Brewster Building 0B203"
                },
                CampusName = "Main Campus",
                ClassDays = new List<string>{
                    "Tuesday,Thursday"
                },
                ClassTimes = new List<string>{
                    "11:00 am - 12:15 pm"
                },
                CourseSeat = seat3,
                Prerequisites = "",
                TextbookName = "Software Foundations, ISBN: 9780470011387, Author: Jobs",
                TextbookNewPrice = 100.00,
                TextbookUsedPrice = 75.00,
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
                Subject = "Software Engineering",
                CourseTerm = "Spring 2018",
                RegistrationStartDate = new DateTime(2017, 11, 3),
                RegistrationEndDate = new DateTime(2018, 1, 12),
                ClassStartDate = new DateTime(2018, 1, 8),
                ClassEndDate = new DateTime(2018, 5, 3),
                ClassInstructionalMethod = "Face to Face",
                CreditHours = 3,
                InstructorName = "Junhua Ding",
                ClassroomName = new List<string>{
                    "Joyner East 00214"
                },
                CampusName = "Main Campus",
                ClassDays = new List<string>{
                    "Tuesday,Thursday"
                },
                ClassTimes = new List<string>{
                    "2:00 pm - 3:15 pm"
                },
                CourseSeat = seat4,
                Prerequisites = "Graduate level SENG 6230 Minimum Grade of C",
                TextbookName = "Software Modeling Concepts, ISBN: 9780470097573, Author: Gates",
                TextbookNewPrice = 80.00,
                TextbookUsedPrice = 55.00,
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
                Subject = "Software Engineering",
                CourseTerm = "Spring 2018",
                RegistrationStartDate = new DateTime(2017, 11, 3),
                RegistrationEndDate = new DateTime(2018, 1, 12),
                ClassStartDate = new DateTime(2018, 1, 8),
                ClassEndDate = new DateTime(2018, 5, 3),
                ClassInstructionalMethod = "Internet or World Wide Web",
                CreditHours = 3,
                InstructorName = "Junhua Ding",
                ClassroomName = new List<string>{
                    "N/A"
                },
                CampusName = "De/Internet Campus",
                ClassDays = new List<string>{
                    "Tuesday,Thursday"
                },
                ClassTimes = new List<string>{
                    "2:00 pm - 3:15 pm"
                },
                CourseSeat = seat5,
                Prerequisites = "Graduate level SENG 6230 Minimum Grade of C",
                TextbookName = "Software Modeling Concepts, ISBN: 9780470097573, Author: Gates",
                TextbookNewPrice = 80.00,
                TextbookUsedPrice = 55.00,
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
                Subject = "Computer Science",
                CourseTerm = "Spring 2018",
                RegistrationStartDate = new DateTime(2017, 11, 3),
                RegistrationEndDate = new DateTime(2018, 1, 12),
                ClassStartDate = new DateTime(2018, 1, 8),
                ClassEndDate = new DateTime(2018, 5, 3),
                ClassInstructionalMethod = "Face to Face",
                CreditHours = 3,
                InstructorName = "Robert Dancy Hoggard",
                ClassroomName = new List<string>{
                    "Howell Science Complex C103B"
                },
                CampusName = "Main Campus",
                ClassDays = new List<string>{
                    "Monday,Wednesday,Friday"
                },
                ClassTimes = new List<string>{
                    "1:00 pm - 1:50 pm"
                },
                CourseSeat = seat6,
                Prerequisites = "Undergraduate level MATH 1065 Minimum Grade of D- or Undergraduate level CSCI 1000 Minimum Grade of C",
                TextbookName = "Java: An Intro to Problem Solving & Programming, ISBN: 9780134462035, Author: Savitch",
                TextbookNewPrice = 158.00,
                TextbookUsedPrice = 118.50,
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
                Subject = "Computer Science",
                CourseTerm = "Spring 2018",
                RegistrationStartDate = new DateTime(2017, 11, 3),
                RegistrationEndDate = new DateTime(2018, 1, 12),
                ClassStartDate = new DateTime(2018, 1, 8),
                ClassEndDate = new DateTime(2018, 5, 3),
                ClassInstructionalMethod = "Face to Face",
                CreditHours = 3,
                InstructorName = "Robert Dancy Hoggard",
                ClassroomName = new List<string>{
                    "Bate Building 01025"
                },
                CampusName = "Main Campus",
                ClassDays = new List<string>{
                    "Monday"
                },
                ClassTimes = new List<string>{
                    "1:00 pm - 2:40 pm"
                },
                CourseSeat = seat6,
                Prerequisites = "",
                TextbookName = "No Course Materials Required",
                TextbookNewPrice = 0.00,
                TextbookUsedPrice = 0.00,
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
                Subject = "Computer Science",
                CourseTerm = "Spring 2018",
                RegistrationStartDate = new DateTime(2017, 11, 3),
                RegistrationEndDate = new DateTime(2018, 1, 12),
                ClassStartDate = new DateTime(2018, 1, 8),
                ClassEndDate = new DateTime(2018, 5, 3),
                ClassInstructionalMethod = "Face to Face",
                CreditHours = 3,
                InstructorName = "Robert Dancy Hoggard",
                ClassroomName = new List<string>{
                    "Bate Building 01025"
                },
                CampusName = "Main Campus",
                ClassDays = new List<string>{
                    "Tuesday"
                },
                ClassTimes = new List<string>{
                    "2:30 pm - 4:10 pm"
                },
                CourseSeat = seat8,
                Prerequisites = "",
                TextbookName = "No Course Materials Required",
                TextbookNewPrice = 0.00,
                TextbookUsedPrice = 0.00,
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
                Subject = "Computer Science",
                CourseTerm = "Spring 2018",
                RegistrationStartDate = new DateTime(2017, 11, 3),
                RegistrationEndDate = new DateTime(2018, 1, 12),
                ClassStartDate = new DateTime(2018, 1, 8),
                ClassEndDate = new DateTime(2018, 5, 3),
                ClassInstructionalMethod = "Face to Face",
                CreditHours = 3,
                InstructorName = "Krishnan Gopalakrishnan",
                ClassroomName = new List<string>{
                    "Brewster Building 0B304"
                },
                CampusName = "Main Campus",
                ClassDays = new List<string>{
                    "Tuesday,Thursday"
                },
                ClassTimes = new List<string>{
                    "3:30 pm - 4:45 pm"
                },
                CourseSeat = seat9,
                Prerequisites = "Undergraduate level MATH 1065 Minimum Grade of D-",
                TextbookName = "Discrete Mathematics & ITS Appl, ISBN: 9780073383095, Author: Rosen",
                TextbookNewPrice = 293.70,
                TextbookUsedPrice = 220.30,
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
                Subject = "Computer Science",
                CourseTerm = "Spring 2018",
                RegistrationStartDate = new DateTime(2017, 11, 3),
                RegistrationEndDate = new DateTime(2018, 1, 12),
                ClassStartDate = new DateTime(2018, 1, 8),
                ClassEndDate = new DateTime(2018, 5, 3),
                ClassInstructionalMethod = "Face to Face",
                CreditHours = 3,
                InstructorName = "Qin Ding",
                ClassroomName = new List<string>{
                    "Howell Science Complex 0N107"
                },
                CampusName = "Main Campus",
                ClassDays = new List<string>{
                    "Tuesday,Thursday"
                },
                ClassTimes = new List<string>{
                    "9:30 am - 10:45 am"
                },
                CourseSeat = seat10,
                Prerequisites = "(Undergraduate level CSCI 2530 Minimum Grade of C or Undergraduate level CSCI 3300 Minimum Grade of C) and Undergraduate level CSCI 2405 Minimum Grade of C",
                TextbookName = "Data Abstraction & Problem Solving with Java, ISBN: 9780132122306, Author: Carrano",
                TextbookNewPrice = 176.00,
                TextbookUsedPrice = 132.00,
                CourseLevels = new List<string>{
                    "Undergraduate"
                }

            };

            Seat seat11 = new Seat();
            seat11.Capacity = 25;
            seat11.Actual = 25;
            seat11.Remaining = seat11.Capacity - seat11.Actual;
            seat11.WaitlistCapacity = 10;
            seat11.WaitlistActual = 5;
            seat11.WaitlistRemaining = seat11.WaitlistCapacity - seat11.WaitlistActual;

            Course course11 = new Course
            {
                ID = 11,
                CourseName = "Public Speaking",
                CourseRegistarCode = "34988",
                CourseSubjectCode = "COMM 2410",
                SectionNumber = "001",
                Subject = "Communication",
                CourseTerm = "Spring 2018",
                RegistrationStartDate = new DateTime(2017, 11, 3),
                RegistrationEndDate = new DateTime(2018, 1, 12),
                ClassStartDate = new DateTime(2018, 1, 8),
                ClassEndDate = new DateTime(2018, 5, 3),
                ClassInstructionalMethod = "Face to Face",
                CreditHours = 3,
                InstructorName = "Kelsey Elisabeth Rhodes",
                ClassroomName = new List<string>{
                    "Joyner East 00214"
                },
                CampusName = "Main Campus",
                ClassDays = new List<string>{
                    "Tuesday,Thursday"
                },
                ClassTimes = new List<string>{
                    "8:00 am - 9:15 am"
                },
                CourseSeat = seat11,
                Prerequisites = "",
                TextbookName = "Essentials of Public Speaking, ISBN: 9781285159454, Author: Hamilton",
                TextbookNewPrice = 63.55,
                TextbookUsedPrice = 47.70,
                CourseLevels = new List<string>{
                    "Undergraduate"
                }

            };

            Seat seat12 = new Seat();
            seat12.Capacity = 25;
            seat12.Actual = 22;
            seat12.Remaining = seat12.Capacity - seat12.Actual;
            seat12.WaitlistCapacity = 10;
            seat12.WaitlistActual = 0;
            seat12.WaitlistRemaining = seat12.WaitlistCapacity - seat12.WaitlistActual;

            Course course12 = new Course
            {
                ID = 12,
                CourseName = "Public Speaking",
                CourseRegistarCode = "34989",
                CourseSubjectCode = "COMM 2410",
                SectionNumber = "002",
                Subject = "Communication",
                CourseTerm = "Spring 2018",
                RegistrationStartDate = new DateTime(2017, 11, 3),
                RegistrationEndDate = new DateTime(2018, 1, 12),
                ClassStartDate = new DateTime(2018, 1, 8),
                ClassEndDate = new DateTime(2018, 5, 3),
                ClassInstructionalMethod = "Face to Face",
                CreditHours = 3,
                InstructorName = "Daniel Addison Wiseman",
                ClassroomName = new List<string>{
                    "Joyner East 00214"
                },
                CampusName = "Main Campus",
                ClassDays = new List<string>{
                    "Tuesday"
                },
                ClassTimes = new List<string>{
                    "6:00 pm - 9:00 pm"
                },
                CourseSeat = seat12,
                Prerequisites = "",
                TextbookName = "Essentials of Public Speaking, ISBN: 9781285159454, Author: Hamilton",
                TextbookNewPrice = 63.55,
                TextbookUsedPrice = 47.70,
                CourseLevels = new List<string>{
                    "Undergraduate"
                }

            };

            Seat seat13 = new Seat();
            seat13.Capacity = 36;
            seat13.Actual = 35;
            seat13.Remaining = seat13.Capacity - seat13.Actual;
            seat13.WaitlistCapacity = 50;
            seat13.WaitlistActual = 0;
            seat13.WaitlistRemaining = seat13.WaitlistCapacity - seat13.WaitlistActual;

            Course course13 = new Course
            {
                ID = 13,
                CourseName = "Calculus I",
                CourseRegistarCode = "30562",
                CourseSubjectCode = "MATH 2171",
                SectionNumber = "002",
                Subject = "Mathematics",
                CourseTerm = "Spring 2018",
                RegistrationStartDate = new DateTime(2017, 11, 3),
                RegistrationEndDate = new DateTime(2018, 1, 12),
                ClassStartDate = new DateTime(2018, 1, 8),
                ClassEndDate = new DateTime(2018, 5, 3),
                ClassInstructionalMethod = "Face to Face",
                CreditHours = 3,
                InstructorName = "Johannes Hendrik Hattingh",
                ClassroomName = new List<string>{
                    "Rawl Building And Annex 00206"
                },
                CampusName = "Main Campus",
                ClassDays = new List<string>{
                    "Tuesday,Thursday"
                },
                ClassTimes = new List<string>{
                    "11:00 am - 12:40 pm"
                },
                CourseSeat = seat13,
                Prerequisites = "Undergraduate level MATH 1083 Minimum Grade of C- or Undergraduate level MATH 1085 Minimum Grade of C- or Undergraduate level MATH 2122 Minimum Grade of C- or SAT Mathematics 630 or ALEKS Math Placement 076 or Math Section Score 650 or ACT Math 28",
                TextbookName = "Calculus, ISBN: 9781285740621, Author: Stewart",
                TextbookNewPrice = 299.99,
                TextbookUsedPrice = 225.00,
                CourseLevels = new List<string>{
                    "Graduate,Undergraduate"
                }

            };

            Seat seat14 = new Seat();
            seat14.Capacity = 36;
            seat14.Actual = 31;
            seat14.Remaining = seat14.Capacity - seat14.Actual;
            seat14.WaitlistCapacity = 50;
            seat14.WaitlistActual = 0;
            seat14.WaitlistRemaining = seat14.WaitlistCapacity - seat14.WaitlistActual;

            Course course14 = new Course
            {
                ID = 14,
                CourseName = "Calculus I",
                CourseRegistarCode = "30563",
                CourseSubjectCode = "MATH 2171",
                SectionNumber = "003",
                Subject = "Mathematics",
                CourseTerm = "Spring 2018",
                RegistrationStartDate = new DateTime(2017, 11, 3),
                RegistrationEndDate = new DateTime(2018, 1, 12),
                ClassStartDate = new DateTime(2018, 1, 8),
                ClassEndDate = new DateTime(2018, 5, 3),
                ClassInstructionalMethod = "Face to Face",
                CreditHours = 3,
                InstructorName = "Heather Dawn Ries",
                ClassroomName = new List<string>{
                    "Austin Building 00203"
                },
                CampusName = "Main Campus",
                ClassDays = new List<string>{
                    "Monday,Wednesday"
                },
                ClassTimes = new List<string>{
                    "9:00 am - 10:40 am"
                },
                CourseSeat = seat14,
                Prerequisites = "Undergraduate level MATH 1083 Minimum Grade of C- or Undergraduate level MATH 1085 Minimum Grade of C- or Undergraduate level MATH 2122 Minimum Grade of C- or SAT Mathematics 630 or ALEKS Math Placement 076 or Math Section Score 650 or ACT Math 28",
                TextbookName = "Calculus (LL Text with Access), ISBN: 9781305616684, Author: Stewart",
                TextbookNewPrice = 172.00,
                TextbookUsedPrice = 0.00,
                CourseLevels = new List<string>{
                    "Graduate,Undergraduate"
                }

            };

            Seat seat15 = new Seat();
            seat15.Capacity = 36;
            seat15.Actual = 36;
            seat15.Remaining = seat15.Capacity - seat15.Actual;
            seat15.WaitlistCapacity = 50;
            seat15.WaitlistActual = 0;
            seat15.WaitlistRemaining = seat15.WaitlistCapacity - seat15.WaitlistActual;

            Course course15 = new Course
            {
                ID = 15,
                CourseName = "Calculus II",
                CourseRegistarCode = "30564",
                CourseSubjectCode = "MATH 2172",
                SectionNumber = "001",
                Subject = "Mathematics",
                CourseTerm = "Spring 2018",
                RegistrationStartDate = new DateTime(2017, 11, 3),
                RegistrationEndDate = new DateTime(2018, 1, 12),
                ClassStartDate = new DateTime(2018, 1, 8),
                ClassEndDate = new DateTime(2018, 5, 3),
                ClassInstructionalMethod = "Face to Face",
                CreditHours = 3,
                InstructorName = "Gail L Ratcliff",
                ClassroomName = new List<string>{
                    "Austin Building 00203"
                },
                CampusName = "Main Campus",
                ClassDays = new List<string>{
                    "Monday,Wednesday"
                },
                ClassTimes = new List<string>{
                    "2:00 pm - 3:40 pm"
                },
                CourseSeat = seat15,
                Prerequisites = "Undergraduate level MATH 2171 Minimum Grade of C-",
                TextbookName = "Calculus (LL Text with Access), ISBN: 9781305616684, Author: Stewart",
                TextbookNewPrice = 172.00,
                TextbookUsedPrice = 0.00,
                CourseLevels = new List<string>{
                    "Undergraduate"
                }

            };

            Seat seat16 = new Seat();
            seat16.Capacity = 48;
            seat16.Actual = 48;
            seat16.Remaining = seat16.Capacity - seat16.Actual;
            seat16.WaitlistCapacity = 50;
            seat16.WaitlistActual = 0;
            seat16.WaitlistRemaining = seat16.WaitlistCapacity - seat16.WaitlistActual;

            Course course16 = new Course
            {
                ID = 16,
                CourseName = "Statistics for Business",
                CourseRegistarCode = "30619",
                CourseSubjectCode = "MATH 2283",
                SectionNumber = "001",
                Subject = "Mathematics",
                CourseTerm = "Spring 2018",
                RegistrationStartDate = new DateTime(2017, 11, 3),
                RegistrationEndDate = new DateTime(2018, 1, 12),
                ClassStartDate = new DateTime(2018, 1, 8),
                ClassEndDate = new DateTime(2018, 5, 3),
                ClassInstructionalMethod = "Face to Face",
                CreditHours = 3,
                InstructorName = "Deborah K Ferrell",
                ClassroomName = new List<string>{
                    "Austin Building 00220"
                },
                CampusName = "Main Campus",
                ClassDays = new List<string>{
                    "Monday,Wednesday,Friday"
                },
                ClassTimes = new List<string>{
                    "9:00 am - 9:50 am"
                },
                CourseSeat = seat16,
                Prerequisites = "Undergraduate level MATH 1065 Minimum Grade of D- or Undergraduate level MATH 1050 Minimum Grade of D- or Undergraduate level MATH 1066 Minimum Grade of D- or Undergraduate level MATH 1077 Minimum Grade of D- or Undergraduate level MATH 1083 Minimum Grade of D- or Undergraduate level MATH 2121 Minimum Grade of D- or Undergraduate level MATH 2122 Minimum Grade of D- or Undergraduate level MATH 2171 Minimum Grade of D- or Undergraduate level MATH 2172 Minimum Grade of D- or Undergraduate level MATH 2173 Minimum Grade of D- or ACT Math 23 or SAT Mathematics 550 or ALEKS Math Placement 053 or ECU-Accuplacer Math Placement 095 or Math Section Score 570",
                TextbookName = "Business Statistics PKG (ECU) with MyStatsLab Business, ISBN: 9781269890281, Author: Donnelly",
                TextbookNewPrice = 255.00,
                TextbookUsedPrice = 0.00,
                CourseLevels = new List<string>{
                    "Graduate,Undergraduate"
                }

            };

            Seat seat17 = new Seat();
            seat17.Capacity = 53;
            seat17.Actual = 51;
            seat17.Remaining = seat17.Capacity - seat17.Actual;
            seat17.WaitlistCapacity = 50;
            seat17.WaitlistActual = 0;
            seat17.WaitlistRemaining = seat17.WaitlistCapacity - seat17.WaitlistActual;

            Course course17 = new Course
            {
                ID = 17,
                CourseName = "Statistics for Business",
                CourseRegistarCode = "30635",
                CourseSubjectCode = "MATH 2283",
                SectionNumber = "601",
                Subject = "Mathematics",
                CourseTerm = "Spring 2018",
                RegistrationStartDate = new DateTime(2017, 11, 3),
                RegistrationEndDate = new DateTime(2018, 1, 12),
                ClassStartDate = new DateTime(2018, 1, 8),
                ClassEndDate = new DateTime(2018, 5, 3),
                ClassInstructionalMethod = "Internet or World Wide Web",
                CreditHours = 3,
                InstructorName = "Deborah K Ferrell",
                ClassroomName = new List<string>{
                    "N/A"
                },
                CampusName = "De/Internet Campus",
                ClassDays = new List<string>{
                    "N/A"
                },
                ClassTimes = new List<string>{
                    "N/A"
                },
                CourseSeat = seat17,
                Prerequisites = "Undergraduate level MATH 1065 Minimum Grade of D- or Undergraduate level MATH 1050 Minimum Grade of D- or Undergraduate level MATH 1066 Minimum Grade of D- or Undergraduate level MATH 1077 Minimum Grade of D- or Undergraduate level MATH 1083 Minimum Grade of D- or Undergraduate level MATH 2121 Minimum Grade of D- or Undergraduate level MATH 2122 Minimum Grade of D- or Undergraduate level MATH 2171 Minimum Grade of D- or Undergraduate level MATH 2172 Minimum Grade of D- or Undergraduate level MATH 2173 Minimum Grade of D- or ACT Math 23 or SAT Mathematics 550 or ALEKS Math Placement 053 or ECU-Accuplacer Math Placement 095 or Math Section Score 570",
                TextbookName = "Business Statistics PKG (ECU) with MyStatsLab Business, ISBN: 9781269890281, Author: Donnelly",
                TextbookNewPrice = 255.00,
                TextbookUsedPrice = 0.00,
                CourseLevels = new List<string>{
                    "Graduate,Undergraduate"
                }

            };

            Seat seat18 = new Seat();
            seat18.Capacity = 27;
            seat18.Actual = 27;
            seat18.Remaining = seat18.Capacity - seat18.Actual;
            seat18.WaitlistCapacity = 10;
            seat18.WaitlistActual = 0;
            seat18.WaitlistRemaining = seat18.WaitlistCapacity - seat18.WaitlistActual;

            Course course18 = new Course
            {
                ID = 18,
                CourseName = "University Physics I",
                CourseRegistarCode = "35314",
                CourseSubjectCode = "PHYS 2350",
                SectionNumber = "001",
                Subject = "Physics",
                CourseTerm = "Spring 2018",
                RegistrationStartDate = new DateTime(2017, 11, 3),
                RegistrationEndDate = new DateTime(2018, 1, 12),
                ClassStartDate = new DateTime(2018, 1, 8),
                ClassEndDate = new DateTime(2018, 5, 3),
                ClassInstructionalMethod = "Face to Face",
                CreditHours = 3,
                InstructorName = "Regina DeWitt, Wilson Hawkins",
                ClassroomName = new List<string>{
                    "Bate Building 01028",
                    "Howell Science Complex 0E205"
                },
                CampusName = "Main Campus",
                ClassDays = new List<string>{
                    "Monday,Wednesday,Friday",
                    "Tuesday"
                },
                ClassTimes = new List<string>{
                    "1:00 pm - 1:50 pm",
                    "3:00 pm - 3:50 pm"
                },
                CourseSeat = seat18,
                Prerequisites = "Undergraduate level MATH 2121 Minimum Grade of D- or Undergraduate level MATH 2151 Minimum Grade of D- or Undergraduate level MATH 2171 Minimum Grade of D- or Undergraduate level MATH 2122 Minimum Grade of D- or Undergraduate level MATH 2152 Minimum Grade of D- or Undergraduate level MATH 2153 Minimum Grade of D- or Undergraduate level MATH 2154 Minimum Grade of D- or Undergraduate level MATH 2172 Minimum Grade of D- or Undergraduate level MATH 2173 Minimum Grade of D- or Undergraduate level MATH 4221 Minimum Grade of D-",
                TextbookName = "University Physics with Modern Physics, Volume 1 with E-Book, ISBN: 9780134209586, Author: Young",
                TextbookNewPrice = 223.60,
                TextbookUsedPrice = 0.00,
                CourseLevels = new List<string>{
                    "Undergraduate"
                }

            };

            Seat seat19 = new Seat();
            seat19.Capacity = 27;
            seat19.Actual = 27;
            seat19.Remaining = seat19.Capacity - seat19.Actual;
            seat19.WaitlistCapacity = 10;
            seat19.WaitlistActual = 0;
            seat19.WaitlistRemaining = seat19.WaitlistCapacity - seat19.WaitlistActual;

            Course course19 = new Course
            {
                ID = 19,
                CourseName = "University Physics I",
                CourseRegistarCode = "35315",
                CourseSubjectCode = "PHYS 2350",
                SectionNumber = "002",
                Subject = "Physics",
                CourseTerm = "Spring 2018",
                RegistrationStartDate = new DateTime(2017, 11, 3),
                RegistrationEndDate = new DateTime(2018, 1, 12),
                ClassStartDate = new DateTime(2018, 1, 8),
                ClassEndDate = new DateTime(2018, 5, 3),
                ClassInstructionalMethod = "Face to Face",
                CreditHours = 3,
                InstructorName = "Regina DeWitt, Wilson Hawkins",
                ClassroomName = new List<string>{
                    "Bate Building 01028",
                    "Howell Science Complex 0E205"
                },
                CampusName = "Main Campus",
                ClassDays = new List<string>{
                    "Monday,Wednesday,Friday",
                    "Tuesday"
                },
                ClassTimes = new List<string>{
                    "1:00 pm - 1:50 pm",
                    "4:00 pm - 4:50 pm"
                },
                CourseSeat = seat19,
                Prerequisites = "Undergraduate level MATH 2121 Minimum Grade of D- or Undergraduate level MATH 2151 Minimum Grade of D- or Undergraduate level MATH 2171 Minimum Grade of D- or Undergraduate level MATH 2122 Minimum Grade of D- or Undergraduate level MATH 2152 Minimum Grade of D- or Undergraduate level MATH 2153 Minimum Grade of D- or Undergraduate level MATH 2154 Minimum Grade of D- or Undergraduate level MATH 2172 Minimum Grade of D- or Undergraduate level MATH 2173 Minimum Grade of D- or Undergraduate level MATH 4221 Minimum Grade of D-",
                TextbookName = "University Physics with Modern Physics, Volume 1 with E-Book, ISBN: 9780134209586, Author: Young",
                TextbookNewPrice = 223.60,
                TextbookUsedPrice = 0.00,
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
                course10,
                course11,
                course12,
                course13,
                course14,
                course15,
                course16,
                course17,
                course18,
                course19
            };

            return courses;
        }
    }
}
