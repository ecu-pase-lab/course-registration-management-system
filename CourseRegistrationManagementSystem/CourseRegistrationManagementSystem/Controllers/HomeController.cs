/**
 * Copyright 2018
 * James Adams IV
 * East Carolina University
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using CourseRegistrationManagementSystem.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using System.Globalization;

namespace CourseRegistrationManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {

        }

        public IActionResult Index()
        {
            ViewBag.Semesters = MockCRMSData.PopulateSemesters();

            return View();
        }

        [HttpPost]
        public IActionResult Search(string selectedSemester)
        {
            ViewBag.Subjects = MockCRMSData.PopulateSubjects();

            ViewBag.ScheduleTypes = MockCRMSData.PopulateScheduleTypes();

            ViewBag.InstructionalMethods = MockCRMSData.PopulateInstructionalMethods();

            ViewBag.Campuses = MockCRMSData.PopulateCampuses();

            ViewBag.CourseLevels = MockCRMSData.PopulateCourseLevels();

            List<string> instructorsList = MockCRMSData.PopulateInstructors();

            ViewBag.InstructorsJSON = JsonConvert.SerializeObject(instructorsList, Formatting.Indented);

            return View();
        }

        [HttpPost]
        public IActionResult CourseResults(List<string> selectedSubjects, List<string> selectedCampuses, string selectedInstructors, List<string> selectedCourseLevels, List<string> selectedInstructionalMethods, List<string> selectedScheduleTypes,
                                           string CourseTitle, string CourseNumber, string creditHourRangeStart, string creditHourRangeEnd, string Monday, string Tuesday, string Wednesday, string Thursday, string Friday, string Saturday, string Sunday, 
                                           string startTimeTimepicker, string endTimeTimepicker)
        {
            List<Course> allCourses = MockCRMSData.PopulateCourses();

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

            if (!(selectedInstructors == null || selectedInstructors.Equals("")))
            {
                coursesToReturn = findCoursesByInstructors(coursesToReturn, selectedInstructors);
            }

            if (!(selectedScheduleTypes.Count() == 0 || (selectedScheduleTypes.Count() == 1 && selectedScheduleTypes.First().Equals("All"))))
            {
                coursesToReturn = findCoursesByScheduleTypes(coursesToReturn, selectedScheduleTypes);
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

            if (!(startTimeTimepicker == null || startTimeTimepicker.Equals("")) && !(endTimeTimepicker == null || endTimeTimepicker.Equals("")))
            {
                coursesToReturn = findCoursesByClassTimes(coursesToReturn, startTimeTimepicker, endTimeTimepicker);
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
            List<ScheduledCourse> onlineCourses = new List<ScheduledCourse>();

            if (scheduledCourses != null)
            {
                foreach (Course course in scheduledCourses)
                {
                    List<string> classDays = course.ClassDays;
                    List<string> classTimes = course.ClassTimes;
                    List<string> classroomNames = course.ClassroomNames;
                    List<double> classroomLatitudes = course.ClassroomLatitudes;
                    List<double> classroomLongitudes = course.ClassroomLongitudes;

                    for (int i = 0; i < classDays.Count; i++) 
                    {
                        string datesWithCommas = classDays.ElementAt(i);
                        string[] days = datesWithCommas.Split(",");

                        foreach (string day in days)
                        {
                            ScheduledCourse courseToAdd = new ScheduledCourse();
                            courseToAdd.ID = course.ID;
                            courseToAdd.ClassName = course.CourseSubjectCode + "-" + course.SectionNumber + " " + course.CourseName;

                            if (course.CampusName.Equals("DE/Internet Campus"))
                            {
                                if (!onlineCourses.Any(c => c.ID == course.ID))
                                {
                                    onlineCourses.Add(courseToAdd);
                                }
                            } else {
                                courseToAdd.ClassTime = classTimes.ElementAt(i);
                                courseToAdd.ClassroomName = classroomNames.ElementAt(i);
                                courseToAdd.ClassroomLatitude = classroomLatitudes.ElementAt(i);
                                courseToAdd.ClassroomLongitude = classroomLongitudes.ElementAt(i);

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
            }

            mondayCourses.Sort(
                delegate (ScheduledCourse sc1, ScheduledCourse sc2)
                {
                    TimeSpan sc1ClassStartTimeSpan = parseStartTimeFromClassTime(sc1.ClassTime);

                    TimeSpan sc2ClassStartTimeSpan = parseStartTimeFromClassTime(sc2.ClassTime);

                    return sc1ClassStartTimeSpan.CompareTo(sc2ClassStartTimeSpan);
                }
            );

            tuesdayCourses.Sort(
                delegate (ScheduledCourse sc1, ScheduledCourse sc2)
                {
                    TimeSpan sc1ClassStartTimeSpan = parseStartTimeFromClassTime(sc1.ClassTime);

                    TimeSpan sc2ClassStartTimeSpan = parseStartTimeFromClassTime(sc2.ClassTime);

                    return sc1ClassStartTimeSpan.CompareTo(sc2ClassStartTimeSpan);
                }
            );

            wednesdayCourses.Sort(
                delegate (ScheduledCourse sc1, ScheduledCourse sc2)
                {
                    TimeSpan sc1ClassStartTimeSpan = parseStartTimeFromClassTime(sc1.ClassTime);

                    TimeSpan sc2ClassStartTimeSpan = parseStartTimeFromClassTime(sc2.ClassTime);

                    return sc1ClassStartTimeSpan.CompareTo(sc2ClassStartTimeSpan);
                }
            );

            thursdayCourses.Sort(
                delegate (ScheduledCourse sc1, ScheduledCourse sc2)
                {
                    TimeSpan sc1ClassStartTimeSpan = parseStartTimeFromClassTime(sc1.ClassTime);

                    TimeSpan sc2ClassStartTimeSpan = parseStartTimeFromClassTime(sc2.ClassTime);

                    return sc1ClassStartTimeSpan.CompareTo(sc2ClassStartTimeSpan);
                }
            );

            fridayCourses.Sort(
                delegate (ScheduledCourse sc1, ScheduledCourse sc2)
                {
                    TimeSpan sc1ClassStartTimeSpan = parseStartTimeFromClassTime(sc1.ClassTime);

                    TimeSpan sc2ClassStartTimeSpan = parseStartTimeFromClassTime(sc2.ClassTime);

                    return sc1ClassStartTimeSpan.CompareTo(sc2ClassStartTimeSpan);
                }
            );

            saturdayCourses.Sort(
                delegate (ScheduledCourse sc1, ScheduledCourse sc2)
                {
                    TimeSpan sc1ClassStartTimeSpan = parseStartTimeFromClassTime(sc1.ClassTime);

                    TimeSpan sc2ClassStartTimeSpan = parseStartTimeFromClassTime(sc2.ClassTime);

                    return sc1ClassStartTimeSpan.CompareTo(sc2ClassStartTimeSpan);
                }
            );

            sundayCourses.Sort(
                delegate (ScheduledCourse sc1, ScheduledCourse sc2)
                {
                    TimeSpan sc1ClassStartTimeSpan = parseStartTimeFromClassTime(sc1.ClassTime);

                    TimeSpan sc2ClassStartTimeSpan = parseStartTimeFromClassTime(sc2.ClassTime);

                    return sc1ClassStartTimeSpan.CompareTo(sc2ClassStartTimeSpan);
                }
            );

            ViewBag.MondayCourses = mondayCourses;
            ViewBag.TuesdayCourses = tuesdayCourses;
            ViewBag.WednesdayCourses = wednesdayCourses;
            ViewBag.ThursdayCourses = thursdayCourses;
            ViewBag.FridayCourses = fridayCourses;
            ViewBag.SaturdayCourses = saturdayCourses;
            ViewBag.SundayCourses = sundayCourses;
            ViewBag.OnlineCourses = onlineCourses;

            return View();
        }

        public TimeSpan parseStartTimeFromClassTime(string classTime)
        {
            int index = classTime.IndexOf('-');
            TimeSpan classStartTimeSpan = new TimeSpan();

            if (index > 0)
            {
                string classStartTime = classTime.Substring(0, index - 1);

                classStartTimeSpan = DateTime.ParseExact(classStartTime, "h:mm tt", CultureInfo.InvariantCulture).TimeOfDay;
            }

            return classStartTimeSpan;
        }

        [HttpPost]
        public IActionResult AddCourseToSchedule(int courseId)
        {
            List<Course> scheduledCourses = HttpContext.Session.Get<List<Course>>("scheduledCourses");

            if (scheduledCourses == null)
            {
                scheduledCourses = new List<Course>();
            }

            List<Course> allCourses = MockCRMSData.PopulateCourses();

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

            List<Course> allCourses = MockCRMSData.PopulateCourses();

            Course course = allCourses.Find(delegate (Course c) { return c.ID == courseId; });

            if (scheduledCourses.Any(c => c.ID == courseId))
            {
                scheduledCourses.RemoveAll(i => i.ID == courseId);
            }

            HttpContext.Session.Set<List<Course>>("scheduledCourses", scheduledCourses);

            return Content("Removed");
        }

        [HttpPost]
        public IActionResult Directions(string courseToMap1, string courseToMap2)
        {
            string[] courseInfo1 = courseToMap1.Split(',');

            string classroomName1 = courseInfo1[0];
            double classroomLatitude1 = Convert.ToDouble(courseInfo1[1]);
            double classroomLongitude1 = Convert.ToDouble(courseInfo1[2]);

            ViewBag.ClassroomName1 = classroomName1;
            ViewBag.ClassroomLatitude1 = classroomLatitude1;
            ViewBag.ClassroomLongitude1 = classroomLongitude1;

            string[] courseInfo2 = courseToMap2.Split(',');

            string classroomName2 = courseInfo2[0];
            double classroomLatitude2 = Convert.ToDouble(courseInfo2[1]);
            double classroomLongitude2 = Convert.ToDouble(courseInfo2[2]);

            ViewBag.ClassroomName2 = classroomName2;
            ViewBag.ClassroomLatitude2 = classroomLatitude2;
            ViewBag.ClassroomLongitude2 = classroomLongitude2;

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

        private List<Course> findCoursesByInstructors(List<Course> courses, string selectedInstructors)
        {
            List<Course> coursesToReturn = new List<Course>();

            List<string> selectedInstructorsList = new List<string>();
            selectedInstructorsList = selectedInstructors.Split(", ").ToList();

            // Remove duplicates in instructor list
            List<string> selectedInstructorsListNoDuplicates = new List<string>();
            selectedInstructorsListNoDuplicates = new HashSet<string>(selectedInstructorsList).ToList();

            foreach (Course course in courses)
            {
                foreach (string instructor in selectedInstructorsListNoDuplicates)
                {
                    if (instructor.Equals(course.InstructorName))
                    {
                        coursesToReturn.Add(course);
                    }
                }
            }

            return coursesToReturn;
        }

        private List<Course> findCoursesByScheduleTypes(List<Course> courses, List<string> selectedScheduleTypes)
        {
            List<Course> coursesToReturn = new List<Course>();

            foreach (Course course in courses)
            {
                foreach (string scheduleType in selectedScheduleTypes)
                {
                    if (scheduleType.Equals(course.ScheduleType))
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
            List<string> allSelectedDays = new List<string>();

            // Create list of each selected day
            if (monday != null && !("".Equals(monday)))
            {
                allSelectedDays.Add(monday);
            }
            if (tuesday != null && !("".Equals(tuesday)))
            {
                allSelectedDays.Add(tuesday);
            }
            if (wednesday != null && !("".Equals(wednesday)))
            {
                allSelectedDays.Add(wednesday);
            }
            if (thursday != null && !("".Equals(thursday)))
            {
                allSelectedDays.Add(thursday);
            }
            if (friday != null && !("".Equals(friday)))
            {
                allSelectedDays.Add(friday);
            }
            if (saturday != null && !("".Equals(saturday)))
            {
                allSelectedDays.Add(saturday);
            }
            if (sunday != null && !("".Equals(sunday)))
            {
                allSelectedDays.Add(sunday);
            }

            foreach (Course course in courses)
            {
                List<string> classDays = course.ClassDays;
                List<string> classDaysWithoutCommas = new List<string>();

                // Each string in the ClassDays list is a comma separated set. Some courses may have more than one set (different meeting time for different days)
                foreach (string classDaySet in classDays)
                {
                    List<string> list = classDaySet.Split(',').ToList();

                    foreach (string day in list)
                    {
                        classDaysWithoutCommas.Add(day);
                    }
                }

                // Return course if all selected days from the search criteria are in the course's meeting days
                if (classDaysWithoutCommas.ContainsAll(allSelectedDays))
                {
                    coursesToReturn.Add(course);
                }
            }

            return coursesToReturn;
        }

        private List<Course> findCoursesByClassTimes(List<Course> courses, string startTime, string endTime)
        {
            List<Course> coursesToReturn = new List<Course>();

            string startTimeWithoutSpaces = Regex.Replace(startTime, @"\s+", "");
            string endTimeWithoutSpaces = Regex.Replace(endTime, @"\s+", "");

            string startTimeWithSpaceBeforeSuffix = "";

            if (startTimeWithoutSpaces.Contains("P"))
            {
                startTimeWithSpaceBeforeSuffix = startTimeWithoutSpaces.Replace("P", " P");
            }
            else if (startTimeWithoutSpaces.Contains("A"))
            {
                startTimeWithSpaceBeforeSuffix = startTimeWithoutSpaces.Replace("A", " A");
            }

            string endTimeWithSpaceBeforeSuffix = "";

            if (endTimeWithoutSpaces.Contains("P"))
            {
                endTimeWithSpaceBeforeSuffix = endTimeWithoutSpaces.Replace("P", " P");
            }
            else if (endTimeWithoutSpaces.Contains("A"))
            {
                endTimeWithSpaceBeforeSuffix = endTimeWithoutSpaces.Replace("A", " A");
            }

            TimeSpan startTimeSpan = DateTime.ParseExact(startTimeWithSpaceBeforeSuffix, "h:mm tt", CultureInfo.InvariantCulture).TimeOfDay;
            TimeSpan endTimeSpan = DateTime.ParseExact(endTimeWithSpaceBeforeSuffix, "h:mm tt", CultureInfo.InvariantCulture).TimeOfDay;

            foreach (Course course in courses)
            {
                List<string> classTimes = course.ClassTimes;

                foreach (string classTime in classTimes)
                {
                    string classStartTime = "";
                    string classEndTime = "";

                    int index = classTime.IndexOf('-');
                    if (index > 0)
                    {
                        classStartTime = classTime.Substring(0, index - 1);
                        classEndTime = classTime.Substring(index + 2);

                        TimeSpan classStartTimeSpan = DateTime.ParseExact(classStartTime, "h:mm tt", CultureInfo.InvariantCulture).TimeOfDay;
                        TimeSpan classEndTimeSpan = DateTime.ParseExact(classEndTime, "h:mm tt", CultureInfo.InvariantCulture).TimeOfDay;

                        if (startTimeSpan <= classStartTimeSpan && classEndTimeSpan <= endTimeSpan)
                        {
                            if (!coursesToReturn.Any(c => c.ID == course.ID))
                            {
                                coursesToReturn.Add(course);
                            }
                        }
                    }
                }
            }

            return coursesToReturn;
        }
    }
}
