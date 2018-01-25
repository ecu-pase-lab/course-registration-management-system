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

            List<Campus> campus = PopulateCampus();
            ViewData["CampusList"] = campus;

            List<CourseLevel> courseLevels = PopulateCourseLevels();
            ViewData["CourseLevelList"] = courseLevels;

            List<Instructor> instructors = PopulateInstructors();
            ViewData["InstructorList"] = instructors;

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
            Subject subject1 = new Subject(1, "Computer Science");
            Subject subject2 = new Subject(2, "English");
            Subject subject3 = new Subject(3, "Mathematics");
            Subject subject4 = new Subject(4, "Physics");
            Subject subject5 = new Subject(5, "Software Engineering");
            Subject subject6 = new Subject(6, "Spanish");

            List<Subject> subjectList = new List<Subject>
            {
                subject1,
                subject2,
                subject3,
                subject4,
                subject5,
                subject6
            };
            return subjectList;
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

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
