/**
 * Copyright 2018
 * James Adams IV
 * East Carolina University
 */

using System;
using System.Collections.Generic;

namespace CourseRegistrationManagementSystem.Models
{
    public static class MockCRMSData
    {
        public static List<string> PopulateSemesters()
        {
            List<string> semesters = new List<string>();
            semesters.Add("Spring 2018");

            return semesters;
        }

        public static List<string> PopulateSubjects()
        {
            List<string> subjects = new List<string>();

            subjects.Add("All");
            subjects.Add("Art");
            subjects.Add("Communication");
            subjects.Add("Computer Science");
            subjects.Add("Mathematics");
            subjects.Add("Physics");
            subjects.Add("Software Engineering");

            return subjects;
        }

        public static List<string> PopulateScheduleTypes()
        {
            List<string> scheduleTypes = new List<string>();

            scheduleTypes.Add("All");
            scheduleTypes.Add("Clinical");
            scheduleTypes.Add("Colloquia");
            scheduleTypes.Add("Honors (DO NOT USE)");
            scheduleTypes.Add("Individual Study");
            scheduleTypes.Add("Internship, Field Exp, Coop ED");
            scheduleTypes.Add("Lab");
            scheduleTypes.Add("Lecture");
            scheduleTypes.Add("Lecture and Lab");
            scheduleTypes.Add("Other (DO NOT USE)");
            scheduleTypes.Add("Physical Activity");
            scheduleTypes.Add("Practicum");
            scheduleTypes.Add("Recital, Performance, Ensemble");
            scheduleTypes.Add("Recitation");
            scheduleTypes.Add("Seminar");
            scheduleTypes.Add("Student Teaching");
            scheduleTypes.Add("Studio");

            return scheduleTypes;
        }

        public static List<string> PopulateInstructionalMethods()
        {
            List<string> instructionalMethods = new List<string>();

            instructionalMethods.Add("All");
            instructionalMethods.Add("Face to Face");
            instructionalMethods.Add("Face to Face Remote Site");
            instructionalMethods.Add("Hybrid Primarily Face to Face");
            instructionalMethods.Add("Hybrid Primarily Web");
            instructionalMethods.Add("Interactive Real Time Video");
            instructionalMethods.Add("Internet or World Wide Web"); 
            instructionalMethods.Add("Nontraditional (DO NOT USE)");
            instructionalMethods.Add("Storage Device or NonWeb Media");
            instructionalMethods.Add("Traditional (DO NOT USE)");

            return instructionalMethods;
        }


        public static List<string> PopulateCampuses()
        {
            List<string> campuses = new List<string>();

            campuses.Add("All");
            campuses.Add("DE/Internet Campus");
            campuses.Add("Main Campus");

            return campuses;
        }

        public static List<string> PopulateCourseLevels()
        {
            List<string> courseLevels = new List<string>();

            courseLevels.Add("All");
            courseLevels.Add("Dental");
            courseLevels.Add("Graduate");
            courseLevels.Add("Professional (Doctorate/CAS)");
            courseLevels.Add("Undergraduate");

            return courseLevels;
        }

        public static List<string> PopulateInstructors()
        {
            List<string> instructors = new List<string>();

            //Software Engineering and Computer Science
            instructors.Add("Junhua Ding");
            instructors.Add("Mark Hills");
            instructors.Add("Moha Nassehzadeh-Tabrizi");
            instructors.Add("Sergiy Vilkomir");
            instructors.Add("Robert Dancy Hoggard");
            instructors.Add("Krishnan Gopalakrishnan");
            instructors.Add("Qin Ding");

            //Communication 
            instructors.Add("Kelsey Elisabeth Rhodes");
            instructors.Add("Daniel Addison Wiseman");

            //Mathematics
            instructors.Add("Johannes Hendrik Hattingh");
            instructors.Add("Heather Dawn Ries");
            instructors.Add("Gail L Ratcliff"); 
            instructors.Add("Deborah K Ferrell");

            //Physics
            instructors.Add("Regina DeWitt, Wilson Hawkins");

            //Art
            instructors.Add("Robert Quinn");

            //Sort list alphabetically
            instructors.Sort();

            return instructors;
        }

        public static Course createCourse1() 
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
                ClassroomNames = new List<string>{
                    "Brewster Building 0B204"
                },
                ClassroomLatitudes = new List<double>{
                    35.6047775
                },
                ClassroomLongitudes = new List<double>{
                    -77.362346
                },
                CampusName = "Main Campus",
                ClassDays = new List<string>{
                    "Monday,Wednesday"
                },
                ClassTimes = new List<string>{
                    "2:00 PM - 3:15 PM"
                },
                CourseSeat = seat1,
                Prerequisites = "Graduate level SENG 6230 Minimum Grade of C or Graduate level CSCI 6230 Minimum Grade of C",
                ScheduleType = "Lecture",
                TextbookName = "Program Development in Java, ISBN: 9780201657685, Author: Liskov",
                TextbookNewPrice = 100.00,
                TextbookUsedPrice = 75.00,
                CourseLevels = new List<string>{
                    "Graduate",
                    "Professional (Doctorate/CAS)"
                }

            };

            return course1;
        }

        public static Course createCourse2()
        {
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
                ClassroomNames = new List<string>{
                    "N/A"
                },
                ClassroomLatitudes = new List<double>{
                    
                },
                ClassroomLongitudes = new List<double>{
                    
                },
                CampusName = "DE/Internet Campus",
                ClassDays = new List<string>{
                    "Monday,Wednesday"
                },
                ClassTimes = new List<string>{
                    "12:30 PM - 1:45 PM"
                },
                CourseSeat = seat2,
                Prerequisites = "",
                ScheduleType = "Individual Study",
                TextbookName = "Requirements Engineering, ISBN: 9780470012703, Author: Van Lamsweerd",
                TextbookNewPrice = 87.00,
                TextbookUsedPrice = 65.25,
                CourseLevels = new List<string>{
                    "Graduate",
                    "Professional (Doctorate/CAS)"
                }

            };

            return course2;
        }

        public static Course createCourse3()
        {
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
                ClassroomNames = new List<string>{
                    "Brewster Building 0B203"
                },
                ClassroomLatitudes = new List<double>{
                    35.6047775
                },
                ClassroomLongitudes = new List<double>{
                    -77.362346
                },
                CampusName = "Main Campus",
                ClassDays = new List<string>{
                    "Tuesday,Thursday"
                },
                ClassTimes = new List<string>{
                    "11:00 AM - 12:15 PM"
                },
                CourseSeat = seat3,
                Prerequisites = "",
                ScheduleType = "Lecture",
                TextbookName = "Software Foundations, ISBN: 9780470011387, Author: Jobs",
                TextbookNewPrice = 100.00,
                TextbookUsedPrice = 75.00,
                CourseLevels = new List<string>{
                    "Graduate"
                }

            };

            return course3;
        }

        public static Course createCourse4()
        {
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
                ClassroomNames = new List<string>{
                    "Joyner East 00214"
                },
                ClassroomLatitudes = new List<double>{
                    35.6068811
                },
                ClassroomLongitudes = new List<double>{
                    -77.3675049
                },
                CampusName = "Main Campus",
                ClassDays = new List<string>{
                    "Tuesday,Thursday"
                },
                ClassTimes = new List<string>{
                    "2:00 PM - 3:15 PM"
                },
                CourseSeat = seat4,
                Prerequisites = "Graduate level SENG 6230 Minimum Grade of C",
                ScheduleType = "Lecture",
                TextbookName = "Software Modeling Concepts, ISBN: 9780470097573, Author: Gates",
                TextbookNewPrice = 80.00,
                TextbookUsedPrice = 55.00,
                CourseLevels = new List<string>{
                    "Graduate"
                }

            };

            return course4;
        }

        public static Course createCourse5()
        {
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
                ClassroomNames = new List<string>{
                    "N/A"
                },
                ClassroomLatitudes = new List<double>{
                    
                },
                ClassroomLongitudes = new List<double>{
                    
                },
                CampusName = "DE/Internet Campus",
                ClassDays = new List<string>{
                    "Tuesday,Thursday"
                },
                ClassTimes = new List<string>{
                    "2:00 PM - 3:15 PM"
                },
                CourseSeat = seat5,
                Prerequisites = "Graduate level SENG 6230 Minimum Grade of C",
                ScheduleType = "Lecture",
                TextbookName = "Software Modeling Concepts, ISBN: 9780470097573, Author: Gates",
                TextbookNewPrice = 80.00,
                TextbookUsedPrice = 55.00,
                CourseLevels = new List<string>{
                    "Graduate"
                }

            };

            return course5;
        }

        public static Course createCourse6()
        {
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
                ClassroomNames = new List<string>{
                    "Howell Science Complex C103B"
                },
                ClassroomLatitudes = new List<double>{
                    35.6054165
                },
                ClassroomLongitudes = new List<double>{
                    -77.3635637
                },
                CampusName = "Main Campus",
                ClassDays = new List<string>{
                    "Monday,Wednesday,Friday"
                },
                ClassTimes = new List<string>{
                    "1:00 PM - 1:50 PM"
                },
                CourseSeat = seat6,
                Prerequisites = "Undergraduate level MATH 1065 Minimum Grade of D- or Undergraduate level CSCI 1000 Minimum Grade of C",
                ScheduleType = "Lecture",
                TextbookName = "Java: An Intro to Problem Solving & Programming, ISBN: 9780134462035, Author: Savitch",
                TextbookNewPrice = 158.00,
                TextbookUsedPrice = 118.50,
                CourseLevels = new List<string>{
                    "Undergraduate"
                }

            };

            return course6;
        }

        public static Course createCourse7()
        {
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
                ClassroomNames = new List<string>{
                    "Bate Building 01025"
                },
                ClassroomLatitudes = new List<double>{
                    35.606147
                },
                ClassroomLongitudes = new List<double>{
                    -77.3652414
                },
                CampusName = "Main Campus",
                ClassDays = new List<string>{
                    "Monday"
                },
                ClassTimes = new List<string>{
                    "1:00 PM - 2:40 PM"
                },
                CourseSeat = seat7,
                Prerequisites = "",
                ScheduleType = "Lab",
                TextbookName = "No Course Materials Required",
                TextbookNewPrice = 0.00,
                TextbookUsedPrice = 0.00,
                CourseLevels = new List<string>{
                    "Undergraduate"
                }

            };

            return course7;
        }

        public static Course createCourse8()
        {
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
                ClassroomNames = new List<string>{
                    "Bate Building 01025"
                },
                ClassroomLatitudes = new List<double>{
                    35.606147
                },
                ClassroomLongitudes = new List<double>{
                    -77.3652414
                },
                CampusName = "Main Campus",
                ClassDays = new List<string>{
                    "Tuesday"
                },
                ClassTimes = new List<string>{
                    "2:30 PM - 4:10 PM"
                },
                CourseSeat = seat8,
                Prerequisites = "",
                ScheduleType = "Lab",
                TextbookName = "No Course Materials Required",
                TextbookNewPrice = 0.00,
                TextbookUsedPrice = 0.00,
                CourseLevels = new List<string>{
                    "Undergraduate"
                }

            };

            return course8;
        }

        public static Course createCourse9()
        {
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
                ClassroomNames = new List<string>{
                    "Brewster Building 0B304"
                },
                ClassroomLatitudes = new List<double>{
                    35.6047775
                },
                ClassroomLongitudes = new List<double>{
                    -77.362346
                },
                CampusName = "Main Campus",
                ClassDays = new List<string>{
                    "Tuesday,Thursday"
                },
                ClassTimes = new List<string>{
                    "3:30 PM - 4:45 PM"
                },
                CourseSeat = seat9,
                Prerequisites = "Undergraduate level MATH 1065 Minimum Grade of D-",
                ScheduleType = "Lecture",
                TextbookName = "Discrete Mathematics & ITS Appl, ISBN: 9780073383095, Author: Rosen",
                TextbookNewPrice = 293.70,
                TextbookUsedPrice = 220.30,
                CourseLevels = new List<string>{
                    "Undergraduate"
                }

            };

            return course9;
        }

        public static Course createCourse10()
        {
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
                ClassroomNames = new List<string>{
                    "Howell Science Complex 0N107"
                },
                ClassroomLatitudes = new List<double>{
                    35.6054165
                },
                ClassroomLongitudes = new List<double>{
                    -77.3635637
                },
                CampusName = "Main Campus",
                ClassDays = new List<string>{
                    "Tuesday,Thursday"
                },
                ClassTimes = new List<string>{
                    "9:30 AM - 10:45 AM"
                },
                CourseSeat = seat10,
                Prerequisites = "(Undergraduate level CSCI 2530 Minimum Grade of C or Undergraduate level CSCI 3300 Minimum Grade of C) and Undergraduate level CSCI 2405 Minimum Grade of C",
                ScheduleType = "Lecture",
                TextbookName = "Data Abstraction & Problem Solving with Java, ISBN: 9780132122306, Author: Carrano",
                TextbookNewPrice = 176.00,
                TextbookUsedPrice = 132.00,
                CourseLevels = new List<string>{
                    "Undergraduate"
                }

            };

            return course10;
        }

        public static Course createCourse11()
        {
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
                ClassroomNames = new List<string>{
                    "Joyner East 00214"
                },
                ClassroomLatitudes = new List<double>{
                    35.6068811
                },
                ClassroomLongitudes = new List<double>{
                    -77.3675049
                },
                CampusName = "Main Campus",
                ClassDays = new List<string>{
                    "Tuesday,Thursday"
                },
                ClassTimes = new List<string>{
                    "8:00 AM - 9:15 AM"
                },
                CourseSeat = seat11,
                Prerequisites = "",
                ScheduleType = "Lecture",
                TextbookName = "Essentials of Public Speaking, ISBN: 9781285159454, Author: Hamilton",
                TextbookNewPrice = 63.55,
                TextbookUsedPrice = 47.70,
                CourseLevels = new List<string>{
                    "Undergraduate"
                }

            };

            return course11;
        }

        public static Course createCourse12()
        {
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
                ClassroomNames = new List<string>{
                    "Joyner East 00214"
                },
                ClassroomLatitudes = new List<double>{
                    35.6068811
                },
                ClassroomLongitudes = new List<double>{
                    -77.3675049
                },
                CampusName = "Main Campus",
                ClassDays = new List<string>{
                    "Tuesday"
                },
                ClassTimes = new List<string>{
                    "6:00 PM - 9:00 PM"
                },
                CourseSeat = seat12,
                Prerequisites = "",
                ScheduleType = "Lecture",
                TextbookName = "Essentials of Public Speaking, ISBN: 9781285159454, Author: Hamilton",
                TextbookNewPrice = 63.55,
                TextbookUsedPrice = 47.70,
                CourseLevels = new List<string>{
                    "Undergraduate"
                }

            };

            return course12;
        }

        public static Course createCourse13()
        {
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
                CreditHours = 4,
                InstructorName = "Johannes Hendrik Hattingh",
                ClassroomNames = new List<string>{
                    "Rawl Building And Annex 00206"
                },
                ClassroomLatitudes = new List<double>{
                    35.6062184
                },
                ClassroomLongitudes = new List<double>{
                    -77.3643696
                },
                CampusName = "Main Campus",
                ClassDays = new List<string>{
                    "Tuesday,Thursday"
                },
                ClassTimes = new List<string>{
                    "11:00 AM - 12:40 PM"
                },
                CourseSeat = seat13,
                Prerequisites = "Undergraduate level MATH 1083 Minimum Grade of C- or Undergraduate level MATH 1085 Minimum Grade of C- or Undergraduate level MATH 2122 Minimum Grade of C- or SAT Mathematics 630 or ALEKS Math Placement 076 or Math Section Score 650 or ACT Math 28",
                ScheduleType = "Lecture",
                TextbookName = "Calculus, ISBN: 9781285740621, Author: Stewart",
                TextbookNewPrice = 299.99,
                TextbookUsedPrice = 225.00,
                CourseLevels = new List<string>{
                    "Graduate,Undergraduate"
                }

            };

            return course13;
        }

        public static Course createCourse14()
        {
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
                CreditHours = 4,
                InstructorName = "Heather Dawn Ries",
                ClassroomNames = new List<string>{
                    "Austin Building 00203"
                },
                ClassroomLatitudes = new List<double>{
                    35.6058379
                },
                ClassroomLongitudes = new List<double>{
                    -77.3629044
                },
                CampusName = "Main Campus",
                ClassDays = new List<string>{
                    "Monday,Wednesday"
                },
                ClassTimes = new List<string>{
                    "9:00 AM - 10:40 AM"
                },
                CourseSeat = seat14,
                Prerequisites = "Undergraduate level MATH 1083 Minimum Grade of C- or Undergraduate level MATH 1085 Minimum Grade of C- or Undergraduate level MATH 2122 Minimum Grade of C- or SAT Mathematics 630 or ALEKS Math Placement 076 or Math Section Score 650 or ACT Math 28",
                ScheduleType = "Lecture",
                TextbookName = "Calculus (LL Text with Access), ISBN: 9781305616684, Author: Stewart",
                TextbookNewPrice = 172.00,
                TextbookUsedPrice = 0.00,
                CourseLevels = new List<string>{
                    "Graduate,Undergraduate"
                }

            };

            return course14;
        }

        public static Course createCourse15()
        {
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
                CreditHours = 4,
                InstructorName = "Gail L Ratcliff",
                ClassroomNames = new List<string>{
                    "Austin Building 00203"
                },
                ClassroomLatitudes = new List<double>{
                    35.6058379
                },
                ClassroomLongitudes = new List<double>{
                    -77.3629044
                },
                CampusName = "Main Campus",
                ClassDays = new List<string>{
                    "Monday,Wednesday"
                },
                ClassTimes = new List<string>{
                    "2:00 PM - 3:40 PM"
                },
                CourseSeat = seat15,
                Prerequisites = "Undergraduate level MATH 2171 Minimum Grade of C-",
                ScheduleType = "Lecture",
                TextbookName = "Calculus (LL Text with Access), ISBN: 9781305616684, Author: Stewart",
                TextbookNewPrice = 172.00,
                TextbookUsedPrice = 0.00,
                CourseLevels = new List<string>{
                    "Undergraduate"
                }

            };

            return course15;
        }

        public static Course createCourse16()
        {
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
                ClassroomNames = new List<string>{
                    "Austin Building 00220"
                },
                ClassroomLatitudes = new List<double>{
                    35.6058379
                },
                ClassroomLongitudes = new List<double>{
                    -77.3629044
                },
                CampusName = "Main Campus",
                ClassDays = new List<string>{
                    "Monday,Wednesday,Friday"
                },
                ClassTimes = new List<string>{
                    "9:00 AM - 9:50 AM"
                },
                CourseSeat = seat16,
                Prerequisites = "Undergraduate level MATH 1065 Minimum Grade of D- or Undergraduate level MATH 1050 Minimum Grade of D- or Undergraduate level MATH 1066 Minimum Grade of D- or Undergraduate level MATH 1077 Minimum Grade of D- or Undergraduate level MATH 1083 Minimum Grade of D- or Undergraduate level MATH 2121 Minimum Grade of D- or Undergraduate level MATH 2122 Minimum Grade of D- or Undergraduate level MATH 2171 Minimum Grade of D- or Undergraduate level MATH 2172 Minimum Grade of D- or Undergraduate level MATH 2173 Minimum Grade of D- or ACT Math 23 or SAT Mathematics 550 or ALEKS Math Placement 053 or ECU-Accuplacer Math Placement 095 or Math Section Score 570",
                ScheduleType = "Lecture",
                TextbookName = "Business Statistics PKG (ECU) with MyStatsLab Business, ISBN: 9781269890281, Author: Donnelly",
                TextbookNewPrice = 255.00,
                TextbookUsedPrice = 0.00,
                CourseLevels = new List<string>{
                    "Graduate,Undergraduate"
                }

            };

            return course16;
        }

        public static Course createCourse17()
        {
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
                ClassroomNames = new List<string>{
                    "N/A"
                },
                ClassroomLatitudes = new List<double>{
                    
                },
                ClassroomLongitudes = new List<double>{
                    
                },
                CampusName = "DE/Internet Campus",
                ClassDays = new List<string>{
                    "N/A"
                },
                ClassTimes = new List<string>{
                    "N/A"
                },
                CourseSeat = seat17,
                Prerequisites = "Undergraduate level MATH 1065 Minimum Grade of D- or Undergraduate level MATH 1050 Minimum Grade of D- or Undergraduate level MATH 1066 Minimum Grade of D- or Undergraduate level MATH 1077 Minimum Grade of D- or Undergraduate level MATH 1083 Minimum Grade of D- or Undergraduate level MATH 2121 Minimum Grade of D- or Undergraduate level MATH 2122 Minimum Grade of D- or Undergraduate level MATH 2171 Minimum Grade of D- or Undergraduate level MATH 2172 Minimum Grade of D- or Undergraduate level MATH 2173 Minimum Grade of D- or ACT Math 23 or SAT Mathematics 550 or ALEKS Math Placement 053 or ECU-Accuplacer Math Placement 095 or Math Section Score 570",
                ScheduleType = "Lecture",
                TextbookName = "Business Statistics PKG (ECU) with MyStatsLab Business, ISBN: 9781269890281, Author: Donnelly",
                TextbookNewPrice = 255.00,
                TextbookUsedPrice = 0.00,
                CourseLevels = new List<string>{
                    "Graduate,Undergraduate"
                }

            };

            return course17;
        }

        public static Course createCourse18()
        {
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
                CreditHours = 4,
                InstructorName = "Regina DeWitt, Wilson Hawkins",
                ClassroomNames = new List<string>{
                    "Bate Building 01028",
                    "Howell Science Complex 0E205"
                },
                ClassroomLatitudes = new List<double>{
                    35.606147,
                    35.6054165
                },
                ClassroomLongitudes = new List<double>{
                    -77.3652414,
                    -77.3635637
                },
                CampusName = "Main Campus",
                ClassDays = new List<string>{
                    "Monday,Wednesday,Friday",
                    "Tuesday"
                },
                ClassTimes = new List<string>{
                    "1:00 PM - 1:50 PM",
                    "3:00 PM - 3:50 PM"
                },
                CourseSeat = seat18,
                Prerequisites = "Undergraduate level MATH 2121 Minimum Grade of D- or Undergraduate level MATH 2151 Minimum Grade of D- or Undergraduate level MATH 2171 Minimum Grade of D- or Undergraduate level MATH 2122 Minimum Grade of D- or Undergraduate level MATH 2152 Minimum Grade of D- or Undergraduate level MATH 2153 Minimum Grade of D- or Undergraduate level MATH 2154 Minimum Grade of D- or Undergraduate level MATH 2172 Minimum Grade of D- or Undergraduate level MATH 2173 Minimum Grade of D- or Undergraduate level MATH 4221 Minimum Grade of D-",
                ScheduleType = "Lecture",
                TextbookName = "University Physics with Modern Physics, Volume 1 with E-Book, ISBN: 9780134209586, Author: Young",
                TextbookNewPrice = 223.60,
                TextbookUsedPrice = 0.00,
                CourseLevels = new List<string>{
                    "Undergraduate"
                }

            };

            return course18;
        }

        public static Course createCourse19()
        {
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
                CreditHours = 4,
                InstructorName = "Regina DeWitt, Wilson Hawkins",
                ClassroomNames = new List<string>{
                    "Bate Building 01028",
                    "Howell Science Complex 0E205"
                },
                ClassroomLatitudes = new List<double>{
                    35.606147,
                    35.6054165
                },
                ClassroomLongitudes = new List<double>{
                    -77.3652414,
                    -77.3635637
                },
                CampusName = "Main Campus",
                ClassDays = new List<string>{
                    "Monday,Wednesday,Friday",
                    "Tuesday"
                },
                ClassTimes = new List<string>{
                    "1:00 PM - 1:50 PM",
                    "4:00 PM - 4:50 PM"
                },
                CourseSeat = seat19,
                Prerequisites = "Undergraduate level MATH 2121 Minimum Grade of D- or Undergraduate level MATH 2151 Minimum Grade of D- or Undergraduate level MATH 2171 Minimum Grade of D- or Undergraduate level MATH 2122 Minimum Grade of D- or Undergraduate level MATH 2152 Minimum Grade of D- or Undergraduate level MATH 2153 Minimum Grade of D- or Undergraduate level MATH 2154 Minimum Grade of D- or Undergraduate level MATH 2172 Minimum Grade of D- or Undergraduate level MATH 2173 Minimum Grade of D- or Undergraduate level MATH 4221 Minimum Grade of D-",
                ScheduleType = "Lecture",
                TextbookName = "University Physics with Modern Physics, Volume 1 with E-Book, ISBN: 9780134209586, Author: Young",
                TextbookNewPrice = 223.60,
                TextbookUsedPrice = 0.00,
                CourseLevels = new List<string>{
                    "Undergraduate"
                }

            };

            return course19;
        }

        public static Course createCourse20()
        {
            Seat seat20 = new Seat();
            seat20.Capacity = 15;
            seat20.Actual = 4;
            seat20.Remaining = seat20.Capacity - seat20.Actual;
            seat20.WaitlistCapacity = 10;
            seat20.WaitlistActual = 0;
            seat20.WaitlistRemaining = seat20.WaitlistCapacity - seat20.WaitlistActual;

            Course course20 = new Course
            {
                ID = 20,
                CourseName = "Computers in Art Education",
                CourseRegistarCode = "31961",
                CourseSubjectCode = "ART 2870",
                SectionNumber = "001",
                Subject = "Art",
                CourseTerm = "Spring 2018",
                RegistrationStartDate = new DateTime(2017, 11, 3),
                RegistrationEndDate = new DateTime(2018, 1, 12),
                ClassStartDate = new DateTime(2018, 1, 8),
                ClassEndDate = new DateTime(2018, 5, 3),
                ClassInstructionalMethod = "Face to Face",
                CreditHours = 1,
                InstructorName = "Robert Quinn",
                ClassroomNames = new List<string>{
                    "Jenkins Fine Arts Center 01108"
                },
                ClassroomLatitudes = new List<double>{
                    35.6089231
                },
                ClassroomLongitudes = new List<double>{
                    -77.3682356
                },
                CampusName = "Main Campus",
                ClassDays = new List<string>{
                    "Tuesday"
                },
                ClassTimes = new List<string>{
                    "9:00 AM - 10:50 AM"
                },
                CourseSeat = seat20,
                Prerequisites = "Undergraduate level ART 1015 Minimum Grade of D- and Undergraduate level ART 1030 Minimum Grade of D-",
                ScheduleType = "Studio",
                TextbookName = "Digital Art, ISBN: 9780500204238, Author: Paul",
                TextbookNewPrice = 21.95,
                TextbookUsedPrice = 16.50,
                CourseLevels = new List<string>{
                    "Undergraduate"
                }

            };

            return course20;
        }

        public static List<Course> PopulateCourses()
        {
            List<Course> courses = new List<Course>
            {
                createCourse1(),
                createCourse2(),
                createCourse3(),
                createCourse4(),
                createCourse5(),
                createCourse6(),
                createCourse7(),
                createCourse8(),
                createCourse9(),
                createCourse10(),
                createCourse11(),
                createCourse12(),
                createCourse13(),
                createCourse14(),
                createCourse15(),
                createCourse16(),
                createCourse17(),
                createCourse18(),
                createCourse19(),
                createCourse20()
            };

            return courses;
        }
    }
}
