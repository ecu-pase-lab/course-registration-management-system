using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CourseRegistrationManagementSystem.Models;

namespace CourseRegistrationManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            List<Semester> semesters = PopulateSemesters();
            ViewData["SemesterList"] = semesters;

            return View();
        }

        [HttpPost]
        public IActionResult Search(string selectedSemester)
        {
            Console.Out.WriteLine("Selected: " + selectedSemester);

            List<Subject> subjects = PopulateSubjects();
            ViewData["SubjectList"] = subjects;

            List<ScheduleType> scheduleTypes = PopulateScheduleTypes();
            ViewData["ScheduleTypeList"] = scheduleTypes;

            List<InstructionalMethod> instructionalMethods = PopulateInstructionalMethods();
            ViewData["InstructionalMethodList"] = instructionalMethods;

            List<Campus> campus = PopulateCampus();
            ViewData["CampusList"] = campus;

            List<CourseLevel> courseLevels = PopulateCourseLevels();
            ViewData["CourseLevelList"] = courseLevels;

            List<TermDuration> termDurations = PopulateTermDurations();
            ViewData["TermDurationList"] = termDurations;

            List<Instructor> instructors = PopulateInstructors();
            ViewData["InstructorList"] = instructors;

            List<Session> sessions = PopulateSessions();
            ViewData["SessionList"] = sessions;

            List<CourseAttribute> courseAttributes = PopulateCourseAttributes();
            ViewData["CourseAttributeList"] = courseAttributes;

            return View();
        }

        [HttpPost]
        public IActionResult CourseResults()
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
                ClassDays = "MW",
                ClassTimes = "2:00 pm - 3:15 pm",
                CourseSeat = seat1,
                Prerequisites = "Graduate level SENG 6230 Minimum Grade of C or Graduate level CSCI 6230 Minimum Grade of C",
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
                ClassDays = "MW",
                ClassTimes = "12:30 pm - 1:45 pm",
                CourseSeat = seat2,
                Prerequisites = "",
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

            ViewBag.CourseList = courses;

            return View();
        }

        private List<Semester> PopulateSemesters()
        {
            Semester semester1 = new Semester(1, "Spring 2018 (View Only)");
            Semester semester2 = new Semester(2, "Spring-Medical 2018 (View Only)");

            List<Semester> semesterList = new List<Semester>
            {
                semester1,
                semester2
            };
            return semesterList;
        }

        private List<Subject> PopulateSubjects()
        {
            Subject subject1 = new Subject(1, "All");
            Subject subject2 = new Subject(2, "Computer Science");
            Subject subject3 = new Subject(3, "English");
            Subject subject4 = new Subject(4, "Mathematics");
            Subject subject5 = new Subject(5, "Physics");
            Subject subject6 = new Subject(6, "Software Engineering");
            Subject subject7 = new Subject(7, "Spanish");

            List<Subject> subjectList = new List<Subject>
            {
                subject1,
                subject2,
                subject3,
                subject4,
                subject5,
                subject6,
                subject7
            };
            return subjectList;
        }

        private List<ScheduleType> PopulateScheduleTypes()
        {
            ScheduleType scheduleType1 = new ScheduleType(1, "All");
            ScheduleType scheduleType2 = new ScheduleType(2, "Clinical");
            ScheduleType scheduleType3 = new ScheduleType(3, "Colloquia");
            ScheduleType scheduleType4 = new ScheduleType(4, "Honors (DO NOT USE)");

            List<ScheduleType> scheduleTypeList = new List<ScheduleType>
            {
                scheduleType1,
                scheduleType2,
                scheduleType3,
                scheduleType4
            };
            return scheduleTypeList;
        }

        private List<InstructionalMethod> PopulateInstructionalMethods()
        {
            InstructionalMethod instructionalMethod1 = new InstructionalMethod(1, "All");
            InstructionalMethod instructionalMethod2 = new InstructionalMethod(2, "Face to Face");
            InstructionalMethod instructionalMethod3 = new InstructionalMethod(3, "Face to Face Remote Site");
            InstructionalMethod instructionalMethod4 = new InstructionalMethod(4, "Hybrid Primarily Face to Face");

            List<InstructionalMethod> instructionalMethodList = new List<InstructionalMethod>
            {
                instructionalMethod1,
                instructionalMethod2,
                instructionalMethod3,
                instructionalMethod4
            };
            return instructionalMethodList;
        }


        private List<Campus> PopulateCampus() {
            Campus campus1 = new Campus(1, "All");
            Campus campus2 = new Campus(2, "DE/Internet");
            Campus campus3 = new Campus(3, "Main Campus");

            List<Campus> campusList = new List<Campus>
            {
                campus1,
                campus2,
                campus3
            };
            return campusList;
        }

        private List<CourseLevel> PopulateCourseLevels()
        {
            CourseLevel courseLevel1 = new CourseLevel(1, "All");
            CourseLevel courseLevel2 = new CourseLevel(2, "Dental");
            CourseLevel courseLevel3 = new CourseLevel(3, "Graduate");
            CourseLevel courseLevel4 = new CourseLevel(4, "Professional (Doctorate/CAS)");
            CourseLevel courseLevel5 = new CourseLevel(5, "Undergraduate");

            List<CourseLevel> courseLevelList = new List<CourseLevel>
            {
                courseLevel1,
                courseLevel2,
                courseLevel3,
                courseLevel4,
                courseLevel5
            };
            return courseLevelList;
        }

        private List<TermDuration> PopulateTermDurations()
        {
            TermDuration termDuration1 = new TermDuration(1, "All");
            TermDuration termDuration2 = new TermDuration(2, "Full Term");

            List<TermDuration> termDurationList = new List<TermDuration>
            {
                termDuration1,
                termDuration2
            };
            return termDurationList;
        }

        private List<Instructor> PopulateInstructors()
        {
            Instructor instructor1 = new Instructor(1, "Ding, Junhua");
            Instructor instructor2 = new Instructor(2, "Hills, Mark");
            Instructor instructor3 = new Instructor(3, "Nassehzadeh-Tabrizi, Moha");
            Instructor instructor4 = new Instructor(4, "Vilkomir, Sergiy");

            List<Instructor> instructorList = new List<Instructor>
            {
                instructor1,
                instructor2,
                instructor3,
                instructor4
            };
            return instructorList;
        }

        private List<Session> PopulateSessions()
        {
            Session session1 = new Session(1, "All");
            Session session2 = new Session(2, "Field-Based Course Eval");
            Session session3 = new Session(3, "Lab-Based Course Eval");
            Session session4 = new Session(4, "Not to be Surveyed Course Eval");

            List<Session> sessionList = new List<Session>
            {
                session1,
                session2,
                session3,
                session4
            };
            return sessionList;
        }

        private List<CourseAttribute> PopulateCourseAttributes()
        {
            CourseAttribute courseAttribute1 = new CourseAttribute(1, "All");
            CourseAttribute courseAttribute2 = new CourseAttribute(2, "AR-Special Music Fees");
            CourseAttribute courseAttribute3 = new CourseAttribute(3, "Bassoon");
            CourseAttribute courseAttribute4 = new CourseAttribute(4, "Cello");
            CourseAttribute courseAttribute5 = new CourseAttribute(5, "Clarinet");

            List<CourseAttribute> courseAttributeList = new List<CourseAttribute>
            {
                courseAttribute1,
                courseAttribute2,
                courseAttribute3,
                courseAttribute4,
                courseAttribute5
            };
            return courseAttributeList;
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Project Information";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Project Contacts";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
