using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CourseRegistrationManagementSystem.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CourseRegistrationManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        private MockCRMSData mockCRMSData;

        public HomeController()
        {
            mockCRMSData = new MockCRMSData();
        }

        public IActionResult Index()
        {
            ViewBag.Semesters = mockCRMSData.PopulateSemesters();

            return View();
        }

        [HttpPost]
        public IActionResult Search(string selectedSemester)
        {
            Console.Out.WriteLine("Selected: " + selectedSemester);

            ViewBag.Subjects = mockCRMSData.PopulateSubjects();

            ViewBag.ScheduleTypes = mockCRMSData.PopulateScheduleTypes();

            ViewBag.InstructionalMethods = mockCRMSData.PopulateInstructionalMethods();

            ViewBag.Campuses = mockCRMSData.PopulateCampuses();

            ViewBag.CourseLevels = mockCRMSData.PopulateCourseLevels();

            ViewBag.TermDurations = mockCRMSData.PopulateTermDurations();

            ViewBag.Instructors = mockCRMSData.PopulateInstructors();

            ViewBag.Sessions = mockCRMSData.PopulateSessions();

            ViewBag.CourseAttributes = mockCRMSData.PopulateCourseAttributes();

            return View();
        }

        [HttpPost]
        public IActionResult CourseResults()
        {
            ViewBag.Courses = mockCRMSData.PopulateCourses();

            return View();
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

        public IActionResult Schedule()
        {
            List<Course> allCourses = mockCRMSData.PopulateCourses();

            List<Course> mondayCourses = new List<Course>();
            List<Course> tuesdayCourses = new List<Course>();
            List<Course> wednesdayCourses = new List<Course>();
            List<Course> thursdayCourses = new List<Course>();
            List<Course> fridayCourses = new List<Course>();
            List<Course> saturdayCourses = new List<Course>();
            List<Course> sundayCourses = new List<Course>();

            foreach (Course course in allCourses) 
            {
                //string classDays = course.ClassDays;
                //List<string> classDaysList = classDays.Split(',').ToList<string>();

                //foreach (string day in classDaysList) 
                //{
                //    if ("Monday".Equals(day))
                //    {
                //        mondayCourses.Add(course);
                //    }
                //    if ("Tuesday".Equals(day))
                //    {
                //        tuesdayCourses.Add(course);
                //    }
                //    if ("Wednesday".Equals(day))
                //    {
                //        wednesdayCourses.Add(course);
                //    }
                //    if ("Thursday".Equals(day))
                //    {
                //        thursdayCourses.Add(course);
                //    }
                //    if ("Friday".Equals(day))
                //    {
                //        fridayCourses.Add(course);
                //    }
                //    if ("Saturday".Equals(day))
                //    {
                //        saturdayCourses.Add(course);
                //    }
                //    if ("Sunday".Equals(day))
                //    {
                //        sundayCourses.Add(course);
                //    }
                //}

            }

            ViewBag.MondayCourses = mondayCourses;
            ViewBag.TuesdayCourses = tuesdayCourses;
            ViewBag.WednesdayCourses = wednesdayCourses;
            ViewBag.ThursdayCourses = thursdayCourses;
            ViewBag.FridayCourses = fridayCourses;
            ViewBag.SaturdayCourses = saturdayCourses;
            ViewBag.SundayCourses = sundayCourses;

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
