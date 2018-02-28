using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CourseRegistrationManagementSystem.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Web;

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
        public IActionResult CourseResults(List<string> selectedSubjects, List<string> selectedCampuses, List<string> selectedInstructors, List<string> selectedCourseLevels, List<string> selectedInstructionalMethods, string CourseTitle,
                                          string CourseNumber)
        {
            List<Course> allCourses = mockCRMSData.PopulateCourses();

            List<Course> coursesToReturn = new List<Course>();


            if (selectedSubjects.Count() == 0 || (selectedSubjects.Count() == 1 && selectedSubjects.First().Equals("All")) )
            {
                coursesToReturn = allCourses;
            } 
            else 
            {
                coursesToReturn = findCoursesBySubjects(allCourses, selectedSubjects);
            }

            if (!(selectedCampuses.Count() == 0 || (selectedCampuses.Count() == 1 && selectedCampuses.First().Equals("All")) ))
            {
                coursesToReturn = findCoursesByCampuses(coursesToReturn, selectedCampuses);
            } 

            if (!(selectedInstructionalMethods.Count() == 0 || (selectedInstructionalMethods.Count() == 1 && selectedInstructionalMethods.First().Equals("All"))))
            {
                coursesToReturn = findCoursesByInstructionalMethods(coursesToReturn, selectedInstructionalMethods);
            }

            if (!(selectedCourseLevels.Count() == 0 || (selectedCourseLevels.Count() == 1 && selectedCourseLevels.First().Equals("All"))))
            {
                coursesToReturn = findCoursesByCourseLevels(coursesToReturn, selectedCourseLevels);
            }

            if (!(selectedInstructors.Count() == 0) )
            {
                coursesToReturn = findCoursesByInstructors(coursesToReturn, selectedInstructors);
            }

            if (!(CourseTitle == null || CourseTitle.Equals("")) )
            {
                coursesToReturn = findCoursesByCourseTitle(coursesToReturn, CourseTitle);
            } 

            if (!(CourseNumber == null || CourseNumber.Equals("")) )
            {
                coursesToReturn = findCoursesByCourseNumber(coursesToReturn, CourseNumber);
            } 

            ViewBag.Courses = coursesToReturn;

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

            //TODO Need to fix schedule because classDays is now a list
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

        private List<Course> findCoursesBySubjects(List<Course> courses, List<string> selectedSubjects) 
        {
            List<Course> coursesToReturn = new List<Course>();

            foreach (Course course in courses)
            {
                foreach (string subject in selectedSubjects)
                {
                    if (subject.Equals(course.Subject))
                    {
                        coursesToReturn.Add(course);
                    }
                }
            }

            return coursesToReturn;
        }

        private List<Course> findCoursesByCampuses(List<Course> courses, List<string> selectedCampuses)
        {
            List<Course> coursesToReturn = new List<Course>();

            foreach (Course course in courses)
            {
                foreach (string campus in selectedCampuses)
                {
                    if (campus.Equals(course.CampusName))
                    {
                        coursesToReturn.Add(course);
                    }
                }
            }

            return coursesToReturn;
        }

        private List<Course> findCoursesByInstructionalMethods(List<Course> courses, List<string> selectedInstructionalMethods)
        {
            List<Course> coursesToReturn = new List<Course>();

            foreach (Course course in courses)
            {
                foreach (string instructionalMethod in selectedInstructionalMethods)
                {
                    if (instructionalMethod.Equals(course.ClassInstructionalMethod))
                    {
                        coursesToReturn.Add(course);
                    }
                }
            }

            return coursesToReturn;
        }

        private List<Course> findCoursesByInstructors(List<Course> courses, List<string> selectedInstructors)
        {
            List<Course> coursesToReturn = new List<Course>();

            foreach (Course course in courses)
            {
                foreach (string instructor in selectedInstructors)
                {
                    if (instructor.Equals(course.InstructorName))
                    {
                        coursesToReturn.Add(course);
                    }
                }
            }

            return coursesToReturn;
        }

        private List<Course> findCoursesByCourseTitle(List<Course> courses, string CourseTitle)
        {
            List<Course> coursesToReturn = new List<Course>();

            foreach (Course course in courses)
            {
                if (course.CourseName.Contains(CourseTitle))
                {
                    coursesToReturn.Add(course);
                }

            }

            return coursesToReturn;
        }

        private List<Course> findCoursesByCourseNumber(List<Course> courses, string CourseNumber)
        {
            List<Course> coursesToReturn = new List<Course>();

            foreach (Course course in courses)
            {
                if (course.CourseSubjectCode.Contains(CourseNumber))
                {
                    coursesToReturn.Add(course);
                }

            }

            return coursesToReturn;
        }

        private List<Course> findCoursesByCourseLevels(List<Course> courses, List<string> selectedCourseLevels)
        {
            List<Course> coursesToReturn = new List<Course>();

            foreach (Course course in courses)
            {
                foreach (string courseLevel in selectedCourseLevels)
                {
                    foreach (string courseLevelInCourse in course.CourseLevels)
                    {
                        if (courseLevel.Equals(courseLevelInCourse))
                        {
                            coursesToReturn.Add(course);
                        }
                    }
                }
            }

            return coursesToReturn;
        }
    }
}
