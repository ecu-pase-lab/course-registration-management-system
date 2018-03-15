using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CourseRegistrationManagementSystem.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

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

            List<string> instructorsList = mockCRMSData.PopulateInstructors();

            ViewBag.InstructorsJSON = JsonConvert.SerializeObject(instructorsList, Formatting.None).Replace("&quot;", "");

            //Console.WriteLine("Output: " + output);

            //var jsonResult = Json(instructorsList);

            //string jsonString = JsonConvert.SerializeObject(jsonResult.Value);

            ViewBag.Instructors = instructorsList;
            //ViewBag.InstructorsJSON = jsonString;

            return View();
        }

        [HttpPost]
        public IActionResult CourseResults(List<string> selectedSubjects, List<string> selectedCampuses, List<string> selectedInstructors, List<string> selectedCourseLevels, List<string> selectedInstructionalMethods, string CourseTitle,
                                           string CourseNumber, string creditHourRangeStart, string creditHourRangeEnd, string Monday, string Tuesday, string Wednesday, string Thursday, string Friday, string Saturday, string Sunday)
        {
            List<Course> allCourses = mockCRMSData.PopulateCourses();

            List<Course> coursesToReturn = allCourses;

            if (!(selectedSubjects.Count() == 0 || (selectedSubjects.Count() == 1 && selectedSubjects.First().Equals("All"))))
            {
                coursesToReturn = findCoursesBySubjects(allCourses, selectedSubjects);
            }

            if (!(selectedCampuses.Count() == 0 || (selectedCampuses.Count() == 1 && selectedCampuses.First().Equals("All"))))
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

            if (!(selectedInstructors.Count() == 0))
            {
                coursesToReturn = findCoursesByInstructors(coursesToReturn, selectedInstructors);
            }

            if (!(CourseTitle == null || CourseTitle.Equals("")))
            {
                coursesToReturn = findCoursesByCourseTitle(coursesToReturn, CourseTitle);
            }

            if (!(CourseNumber == null || CourseNumber.Equals("")))
            {
                coursesToReturn = findCoursesByCourseNumber(coursesToReturn, CourseNumber);
            }

            if (Monday != null || Tuesday != null || Wednesday != null || Thursday != null || Friday != null || Saturday != null || Sunday != null)
            {
                coursesToReturn = findCoursesByClassDays(coursesToReturn, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday);
            }

            coursesToReturn = findCoursesByCreditHourRange(coursesToReturn, creditHourRangeStart, creditHourRangeEnd);

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
            List<Course> scheduledCourses = HttpContext.Session.Get<List<Course>>("scheduledCourses");

            List<ScheduledCourse> mondayCourses = new List<ScheduledCourse>();
            List<ScheduledCourse> tuesdayCourses = new List<ScheduledCourse>();
            List<ScheduledCourse> wednesdayCourses = new List<ScheduledCourse>();
            List<ScheduledCourse> thursdayCourses = new List<ScheduledCourse>();
            List<ScheduledCourse> fridayCourses = new List<ScheduledCourse>();
            List<ScheduledCourse> saturdayCourses = new List<ScheduledCourse>();
            List<ScheduledCourse> sundayCourses = new List<ScheduledCourse>();

            if (scheduledCourses != null)
            {
                foreach (Course course in scheduledCourses)
                {
                    List<string> classDays = course.ClassDays;
                    List<string> classTimes = course.ClassTimes;
                    List<string> classroomNames = course.ClassroomNames;

                    for (int i = 0; i < classDays.Count; i++) 
                    {
                        string datesWithCommas = classDays.ElementAt(i);
                        string[] days = datesWithCommas.Split(",");

                        foreach (string day in days)
                        {
                            ScheduledCourse courseToAdd = new ScheduledCourse();
                            courseToAdd.ID = course.ID;
                            courseToAdd.ClassName = course.CourseSubjectCode + "-" + course.SectionNumber + " " + course.CourseName;
                            courseToAdd.ClassTime = classTimes.ElementAt(i);
                            courseToAdd.ClassroomName = classroomNames.ElementAt(i);

                            if (day.Equals("Monday"))
                            {
                                mondayCourses.Add(courseToAdd);
                            }
                            else if (day.Equals("Tuesday"))
                            {
                                tuesdayCourses.Add(courseToAdd);
                            }
                            else if (day.Equals("Wednesday"))
                            {
                                wednesdayCourses.Add(courseToAdd);
                            }
                            else if (day.Equals("Thursday"))
                            {
                                thursdayCourses.Add(courseToAdd);
                            }
                            else if (day.Equals("Friday"))
                            {
                                fridayCourses.Add(courseToAdd);
                            }
                            else if (day.Equals("Saturday"))
                            {
                                saturdayCourses.Add(courseToAdd);
                            }
                            else if (day.Equals("Sunday"))
                            {
                                sundayCourses.Add(courseToAdd);
                            }
                        }
                    }
                }
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

        [HttpPost]
        public IActionResult AddCourseToSchedule(int courseId)
        {
            List<Course> scheduledCourses = HttpContext.Session.Get<List<Course>>("scheduledCourses");

            if (scheduledCourses == null)
            {
                scheduledCourses = new List<Course>();
            }

            List<Course> allCourses = mockCRMSData.PopulateCourses();

            Course course = allCourses.Find(delegate (Course c) { return c.ID == courseId; });

            if (!scheduledCourses.Any(c => c.ID == courseId))
            {
                scheduledCourses.Add(course);
            }

            HttpContext.Session.Set<List<Course>>("scheduledCourses", scheduledCourses);

            return Content("Added");
        }

        [HttpPost]
        public IActionResult RemoveCourseFromSchedule(int courseId)
        {
            List<Course> scheduledCourses = HttpContext.Session.Get<List<Course>>("scheduledCourses");

            if (scheduledCourses == null)
            {
                scheduledCourses = new List<Course>();
            }

            List<Course> allCourses = mockCRMSData.PopulateCourses();

            Course course = allCourses.Find(delegate (Course c) { return c.ID == courseId; });

            if (scheduledCourses.Any(c => c.ID == courseId))
            {
                scheduledCourses.RemoveAll(i => i.ID == courseId);
            }

            HttpContext.Session.Set<List<Course>>("scheduledCourses", scheduledCourses);

            return Content("Removed");
        }

        public IActionResult Directions()
        {
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
                foreach (string courseLevelInSelected in selectedCourseLevels)
                {
                    foreach (string courseLevelInCourse in course.CourseLevels)
                    {
                        if (courseLevelInCourse.Contains(courseLevelInSelected))
                        {
                            coursesToReturn.Add(course);
                        }
                    }
                }
            }

            return coursesToReturn;
        }

        private List<Course> findCoursesByCreditHourRange(List<Course> courses, string creditHourRangeStart, string creditHourRangeEnd)
        {
            List<Course> coursesToReturn = new List<Course>();

            foreach (Course course in courses)
            {
                if (Convert.ToDouble(creditHourRangeStart) <= course.CreditHours && course.CreditHours <= Convert.ToDouble(creditHourRangeEnd))
                {
                    coursesToReturn.Add(course);
                }

            }

            return coursesToReturn;
        }

        private List<Course> findCoursesByClassDays(List<Course> courses, string monday, string tuesday, string wednesday, string thursday, 
                                                    string friday, string saturday, string sunday)
        {
            List<Course> coursesToReturn = new List<Course>();

            foreach (Course course in courses)
            {
                List<string> classDays = course.ClassDays;

                List<string> allClassDays = new List<string>();

                //Each string in ClassDays list usually contains two or three days (multiple days that have the same class meeting time)
                foreach (string meetingDays in classDays)
                {
                    string[] days = meetingDays.Split(",");

                    foreach (string day in days) 
                    {
                        allClassDays.Add(day);
                    }
                }

                foreach (string day in allClassDays)
                {
                    if (day.Equals(monday))
                    {
                        coursesToReturn.Add(course);
                    }
                    else if (day.Equals(tuesday) && !coursesToReturn.Contains(course))
                    {
                        coursesToReturn.Add(course);
                    }
                    else if (day.Equals(wednesday) && !coursesToReturn.Contains(course))
                    {
                        coursesToReturn.Add(course);
                    }
                    else if (day.Equals(thursday) && !coursesToReturn.Contains(course))
                    {
                        coursesToReturn.Add(course);
                    }
                    else if (day.Equals(friday) && !coursesToReturn.Contains(course))
                    {
                        coursesToReturn.Add(course);
                    }
                    else if (day.Equals(saturday) && !coursesToReturn.Contains(course))
                    {
                        coursesToReturn.Add(course);
                    }
                    else if (day.Equals(sunday) && !coursesToReturn.Contains(course))
                    {
                        coursesToReturn.Add(course);
                    }
                }

            }

            return coursesToReturn;
        }
    }
}
