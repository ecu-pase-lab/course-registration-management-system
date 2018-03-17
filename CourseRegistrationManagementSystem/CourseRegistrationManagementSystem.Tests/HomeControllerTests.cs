using System;
using System.Collections.Generic;
using CourseRegistrationManagementSystem.Models;
using Xunit;

namespace CourseRegistrationManagementSystem.Tests
{
    public class HomeControllerTests
    {
        private Controllers.HomeController controller;

        // Typing in 6230 in the Course Number search field should return only the SENG 6230 course
        [Fact]
        public void searchCoursesByCourseNumberTest()
        {
            controller = new Controllers.HomeController();

            List<string> emptyList = new List<string>();

            controller.CourseResults(emptyList, emptyList, emptyList, emptyList, emptyList, "", "6230", "1", "10", null, null, null, null, null, null, null);

            // Compare values for course
            Assert.Equal(1, controller.ViewBag.Courses.Count);

            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse3(), controller.ViewBag.Courses[0]);
        }

        // Typing in 21 in the Course Number search field should return three Calculus courses (from course numbers 2171 and 2172)
        [Fact]
        public void searchCoursesByPartialCourseNumberTest()
        {
            controller = new Controllers.HomeController();

            List<string> emptyList = new List<string>();

            controller.CourseResults(emptyList, emptyList, emptyList, emptyList, emptyList, "", "21", "1", "10", null, null, null, null, null, null, null);

            // Compare values for all courses
            Assert.Equal(3, controller.ViewBag.Courses.Count);

            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse13(), controller.ViewBag.Courses[0]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse14(), controller.ViewBag.Courses[1]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse15(), controller.ViewBag.Courses[2]);
        }

        // Typing in Physics in the Course Title search field should only return courses with Physics in the course name
        [Fact]
        public void searchCoursesByCourseTitleTest()
        {
            controller = new Controllers.HomeController();

            List<string> emptyList = new List<string>();

            controller.CourseResults(emptyList, emptyList, emptyList, emptyList, emptyList, "Physics", "", "1", "10", null, null, null, null, null, null, null);

            // Compare values for all courses
            Assert.Equal(2, controller.ViewBag.Courses.Count);

            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse18(), controller.ViewBag.Courses[0]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse19(), controller.ViewBag.Courses[1]);
        }

        // Typing in Calc in the Course Title search field should return three Calculus courses
        [Fact]
        public void searchCoursesByPartialCourseTitleTest()
        {
            controller = new Controllers.HomeController();

            List<string> emptyList = new List<string>();

            controller.CourseResults(emptyList, emptyList, emptyList, emptyList, emptyList, "Calc", "", "1", "10", null, null, null, null, null, null, null);

            // Compare values for all courses
            Assert.Equal(3, controller.ViewBag.Courses.Count);

            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse13(), controller.ViewBag.Courses[0]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse14(), controller.ViewBag.Courses[1]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse15(), controller.ViewBag.Courses[2]);
        }

        // Typing in History in the Course Title search field should return no courses
        [Fact]
        public void searchCoursesByNonExistingCourseTitleTest()
        {
            controller = new Controllers.HomeController();

            List<string> emptyList = new List<string>();

            controller.CourseResults(emptyList, emptyList, emptyList, emptyList, emptyList, "History", "", "1", "10", null, null, null, null, null, null, null);

            // Should return no courses
            Assert.Equal(0, controller.ViewBag.Courses.Count);
        }

        // Choosing Mathematics in the Subject drop-down menu should return only courses in that Subject
        [Fact]
        public void searchCoursesBySubjectTest()
        {
            controller = new Controllers.HomeController();

            List<string> emptyList = new List<string>();

            List<string> subjects = new List<string>();
            subjects.Add("Mathematics");

            controller.CourseResults(subjects, emptyList, emptyList, emptyList, emptyList, "", "", "1", "10", null, null, null, null, null, null, null);

            // Compare values for all courses
            Assert.Equal(5, controller.ViewBag.Courses.Count);

            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse13(), controller.ViewBag.Courses[0]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse14(), controller.ViewBag.Courses[1]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse15(), controller.ViewBag.Courses[2]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse16(), controller.ViewBag.Courses[3]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse17(), controller.ViewBag.Courses[4]);
        }

        // Choosing Mathematics and Communication in the Subject drop-down menu should return only courses in those two Subjects
        [Fact]
        public void searchCoursesByMultipleSubjectsTest()
        {
            controller = new Controllers.HomeController();

            List<string> emptyList = new List<string>();

            List<string> subjects = new List<string>();
            subjects.Add("Mathematics");
            subjects.Add("Communication");

            controller.CourseResults(subjects, emptyList, emptyList, emptyList, emptyList, "", "", "1", "10", null, null, null, null, null, null, null);

            // Compare values for all courses
            Assert.Equal(7, controller.ViewBag.Courses.Count);

            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse11(), controller.ViewBag.Courses[0]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse12(), controller.ViewBag.Courses[1]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse13(), controller.ViewBag.Courses[2]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse14(), controller.ViewBag.Courses[3]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse15(), controller.ViewBag.Courses[4]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse16(), controller.ViewBag.Courses[5]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse17(), controller.ViewBag.Courses[6]);
        }

        // Choosing Mark Hills in the Instructor drop-down menu should return only courses that Mark Hills teaches 
        [Fact]
        public void searchCoursesByInstructorTest()
        {
            controller = new Controllers.HomeController();

            List<string> emptyList = new List<string>();

            List<string> instructors = new List<string>();
            instructors.Add("Mark Hills");

            controller.CourseResults(emptyList, emptyList, instructors, emptyList, emptyList, "", "", "1", "10", null, null, null, null, null, null, null);

            // Compare values for course
            Assert.Equal(1, controller.ViewBag.Courses.Count);

            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse1(), controller.ViewBag.Courses[0]);
        }

        // Choosing Mark Hills and Qin Ding in the Instructor drop-down menu should return only courses that Mark Hills or Qin Ding teach 
        [Fact]
        public void searchCoursesByMultipleInstructorsTest()
        {
            controller = new Controllers.HomeController();

            List<string> emptyList = new List<string>();

            List<string> instructors = new List<string>();
            instructors.Add("Mark Hills");
            instructors.Add("Qin Ding");

            controller.CourseResults(emptyList, emptyList, instructors, emptyList, emptyList, "", "", "1", "10", null, null, null, null, null, null, null);

            // Compare values for all courses
            Assert.Equal(2, controller.ViewBag.Courses.Count);

            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse1(), controller.ViewBag.Courses[0]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse10(), controller.ViewBag.Courses[1]);
        }

        // Searching courses worth Credit hours of 1 to 2 should return only courses with 1 to 2 Credit hours 
        [Fact]
        public void searchCoursesByCreditHours1To2Returns1CourseTest()
        {
            controller = new Controllers.HomeController();

            List<string> emptyList = new List<string>();

            controller.CourseResults(emptyList, emptyList, emptyList, emptyList, emptyList, "", "", "1", "2", null, null, null, null, null, null, null);

            // Compare values for course
            Assert.Equal(1, controller.ViewBag.Courses.Count);

            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse20(), controller.ViewBag.Courses[0]);
        }

        // Searching courses worth Credit hours of 3 to 3 should return only courses worth 3 Credit hours, which is all courses except for 1 
        [Fact]
        public void searchCoursesByCreditHours3To3ReturnsAll3HourCoursesTest()
        {
            controller = new Controllers.HomeController();

            List<string> emptyList = new List<string>();

            controller.CourseResults(emptyList, emptyList, emptyList, emptyList, emptyList, "", "", "3", "3", null, null, null, null, null, null, null);

            // Compare values for all courses
            Assert.Equal(19, controller.ViewBag.Courses.Count);

            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse1(), controller.ViewBag.Courses[0]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse2(), controller.ViewBag.Courses[1]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse3(), controller.ViewBag.Courses[2]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse4(), controller.ViewBag.Courses[3]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse5(), controller.ViewBag.Courses[4]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse6(), controller.ViewBag.Courses[5]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse7(), controller.ViewBag.Courses[6]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse8(), controller.ViewBag.Courses[7]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse9(), controller.ViewBag.Courses[8]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse10(), controller.ViewBag.Courses[9]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse11(), controller.ViewBag.Courses[10]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse12(), controller.ViewBag.Courses[11]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse13(), controller.ViewBag.Courses[12]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse14(), controller.ViewBag.Courses[13]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse15(), controller.ViewBag.Courses[14]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse16(), controller.ViewBag.Courses[15]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse17(), controller.ViewBag.Courses[16]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse18(), controller.ViewBag.Courses[17]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse19(), controller.ViewBag.Courses[18]);
        }

        // Searching courses worth Credit hours of 4 to 10 should return no courses 
        [Fact]
        public void searchCoursesByCreditHoursReturnsNoCoursesTest()
        {
            controller = new Controllers.HomeController();

            List<string> emptyList = new List<string>();

            controller.CourseResults(emptyList, emptyList, emptyList, emptyList, emptyList, "", "", "4", "10", null, null, null, null, null, null, null);

            // Should return no courses
            Assert.Equal(0, controller.ViewBag.Courses.Count);
        }

        // Searching courses by choosing Main Campus should return all courses taught in-person
        [Fact]
        public void searchCoursesByMainCampusTest()
        {
            controller = new Controllers.HomeController();

            List<string> emptyList = new List<string>();

            List<string> campuses = new List<string>();
            campuses.Add("Main Campus");

            controller.CourseResults(emptyList, campuses, emptyList, emptyList, emptyList, "", "", "1", "10", null, null, null, null, null, null, null);

            // Compare values for all courses
            Assert.Equal(17, controller.ViewBag.Courses.Count);

            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse1(), controller.ViewBag.Courses[0]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse3(), controller.ViewBag.Courses[1]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse4(), controller.ViewBag.Courses[2]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse6(), controller.ViewBag.Courses[3]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse7(), controller.ViewBag.Courses[4]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse8(), controller.ViewBag.Courses[5]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse9(), controller.ViewBag.Courses[6]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse10(), controller.ViewBag.Courses[7]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse11(), controller.ViewBag.Courses[8]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse12(), controller.ViewBag.Courses[9]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse13(), controller.ViewBag.Courses[10]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse14(), controller.ViewBag.Courses[11]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse15(), controller.ViewBag.Courses[12]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse16(), controller.ViewBag.Courses[13]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse18(), controller.ViewBag.Courses[14]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse19(), controller.ViewBag.Courses[15]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse20(), controller.ViewBag.Courses[16]);
        }

        // Searching courses by choosing DE/Internet Campus should return all courses taught online
        [Fact]
        public void searchCoursesByDECampusTest()
        {
            controller = new Controllers.HomeController();

            List<string> emptyList = new List<string>();

            List<string> campuses = new List<string>();
            campuses.Add("DE/Internet Campus");

            controller.CourseResults(emptyList, campuses, emptyList, emptyList, emptyList, "", "", "1", "10", null, null, null, null, null, null, null);

            // Compare values for all courses
            Assert.Equal(3, controller.ViewBag.Courses.Count);

            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse2(), controller.ViewBag.Courses[0]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse5(), controller.ViewBag.Courses[1]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse17(), controller.ViewBag.Courses[2]);
        }

        // Searching courses by choosing All for Campus should return both courses taught in-person and online
        [Fact]
        public void searchCoursesByAllCampusTest()
        {
            controller = new Controllers.HomeController();

            List<string> emptyList = new List<string>();

            List<string> campuses = new List<string>();
            campuses.Add("All");

            controller.CourseResults(emptyList, campuses, emptyList, emptyList, emptyList, "", "", "1", "10", null, null, null, null, null, null, null);

            // Compare values for all courses
            Assert.Equal(20, controller.ViewBag.Courses.Count);

            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse1(), controller.ViewBag.Courses[0]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse2(), controller.ViewBag.Courses[1]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse3(), controller.ViewBag.Courses[2]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse4(), controller.ViewBag.Courses[3]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse5(), controller.ViewBag.Courses[4]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse6(), controller.ViewBag.Courses[5]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse7(), controller.ViewBag.Courses[6]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse8(), controller.ViewBag.Courses[7]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse9(), controller.ViewBag.Courses[8]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse10(), controller.ViewBag.Courses[9]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse11(), controller.ViewBag.Courses[10]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse12(), controller.ViewBag.Courses[11]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse13(), controller.ViewBag.Courses[12]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse14(), controller.ViewBag.Courses[13]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse15(), controller.ViewBag.Courses[14]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse16(), controller.ViewBag.Courses[15]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse17(), controller.ViewBag.Courses[16]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse18(), controller.ViewBag.Courses[17]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse19(), controller.ViewBag.Courses[18]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse20(), controller.ViewBag.Courses[19]);
        }

        // Choosing All in the Subject drop-down menu should return courses in every Subject
        [Fact]
        public void searchCoursesByAllSubjectTest()
        {
            controller = new Controllers.HomeController();

            List<string> emptyList = new List<string>();

            List<string> subjects = new List<string>();
            subjects.Add("All");

            controller.CourseResults(subjects, emptyList, emptyList, emptyList, emptyList, "", "", "1", "10", null, null, null, null, null, null, null);

            // Compare values for all courses
            Assert.Equal(20, controller.ViewBag.Courses.Count);

            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse1(), controller.ViewBag.Courses[0]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse2(), controller.ViewBag.Courses[1]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse3(), controller.ViewBag.Courses[2]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse4(), controller.ViewBag.Courses[3]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse5(), controller.ViewBag.Courses[4]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse6(), controller.ViewBag.Courses[5]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse7(), controller.ViewBag.Courses[6]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse8(), controller.ViewBag.Courses[7]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse9(), controller.ViewBag.Courses[8]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse10(), controller.ViewBag.Courses[9]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse11(), controller.ViewBag.Courses[10]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse12(), controller.ViewBag.Courses[11]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse13(), controller.ViewBag.Courses[12]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse14(), controller.ViewBag.Courses[13]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse15(), controller.ViewBag.Courses[14]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse16(), controller.ViewBag.Courses[15]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse17(), controller.ViewBag.Courses[16]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse18(), controller.ViewBag.Courses[17]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse19(), controller.ViewBag.Courses[18]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse20(), controller.ViewBag.Courses[19]);
        }

        // Searching courses by choosing Internet or World Wide Web for the Instructional Method should return only courses taught completely online
        [Fact]
        public void searchCoursesByInternetInstructionalMethodTest()
        {
            controller = new Controllers.HomeController();

            List<string> emptyList = new List<string>();

            List<string> instructionalMethods = new List<string>();
            instructionalMethods.Add("Internet or World Wide Web");

            controller.CourseResults(emptyList, emptyList, emptyList, emptyList, instructionalMethods, "", "", "1", "10", null, null, null, null, null, null, null);

            // Compare values for all courses
            Assert.Equal(3, controller.ViewBag.Courses.Count);

            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse2(), controller.ViewBag.Courses[0]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse5(), controller.ViewBag.Courses[1]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse17(), controller.ViewBag.Courses[2]);
        }

        // Searching courses by choosing Face to Face for the Instructional Method should return only courses taught completely in-person
        [Fact]
        public void searchCoursesByFacetoFaceInstructionalMethodTest()
        {
            controller = new Controllers.HomeController();

            List<string> emptyList = new List<string>();

            List<string> instructionalMethods = new List<string>();
            instructionalMethods.Add("Face to Face");

            controller.CourseResults(emptyList, emptyList, emptyList, emptyList, instructionalMethods, "", "", "1", "10", null, null, null, null, null, null, null);

            // Compare values for all courses
            Assert.Equal(17, controller.ViewBag.Courses.Count);

            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse1(), controller.ViewBag.Courses[0]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse3(), controller.ViewBag.Courses[1]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse4(), controller.ViewBag.Courses[2]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse6(), controller.ViewBag.Courses[3]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse7(), controller.ViewBag.Courses[4]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse8(), controller.ViewBag.Courses[5]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse9(), controller.ViewBag.Courses[6]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse10(), controller.ViewBag.Courses[7]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse11(), controller.ViewBag.Courses[8]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse12(), controller.ViewBag.Courses[9]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse13(), controller.ViewBag.Courses[10]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse14(), controller.ViewBag.Courses[11]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse15(), controller.ViewBag.Courses[12]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse16(), controller.ViewBag.Courses[13]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse18(), controller.ViewBag.Courses[14]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse19(), controller.ViewBag.Courses[15]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse20(), controller.ViewBag.Courses[16]);
        }

        // Searching courses by choosing All for the Instructional Method should return all courses 
        [Fact]
        public void searchCoursesByAllInstructionalMethodTest()
        {
            controller = new Controllers.HomeController();

            List<string> emptyList = new List<string>();

            List<string> instructionalMethods = new List<string>();
            instructionalMethods.Add("All");

            controller.CourseResults(emptyList, emptyList, emptyList, emptyList, instructionalMethods, "", "", "1", "10", null, null, null, null, null, null, null);

            // Compare values for all courses
            Assert.Equal(20, controller.ViewBag.Courses.Count);

            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse1(), controller.ViewBag.Courses[0]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse2(), controller.ViewBag.Courses[1]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse3(), controller.ViewBag.Courses[2]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse4(), controller.ViewBag.Courses[3]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse5(), controller.ViewBag.Courses[4]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse6(), controller.ViewBag.Courses[5]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse7(), controller.ViewBag.Courses[6]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse8(), controller.ViewBag.Courses[7]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse9(), controller.ViewBag.Courses[8]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse10(), controller.ViewBag.Courses[9]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse11(), controller.ViewBag.Courses[10]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse12(), controller.ViewBag.Courses[11]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse13(), controller.ViewBag.Courses[12]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse14(), controller.ViewBag.Courses[13]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse15(), controller.ViewBag.Courses[14]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse16(), controller.ViewBag.Courses[15]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse17(), controller.ViewBag.Courses[16]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse18(), controller.ViewBag.Courses[17]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse19(), controller.ViewBag.Courses[18]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse20(), controller.ViewBag.Courses[19]);
        }

        // Searching courses by choosing Hybrid Primarily Web for the Instructional Method should return no courses 
        [Fact]
        public void searchCoursesByHybridPrimarilyWebInstructionalMethodTest()
        {
            controller = new Controllers.HomeController();

            List<string> emptyList = new List<string>();

            List<string> instructionalMethods = new List<string>();
            instructionalMethods.Add("Hybrid Primarily Web");

            controller.CourseResults(emptyList, emptyList, emptyList, emptyList, instructionalMethods, "", "", "1", "10", null, null, null, null, null, null, null);

            // Should return no courses
            Assert.Equal(0, controller.ViewBag.Courses.Count);
        }

        // Searching courses by choosing All for the Course Level should return all courses 
        [Fact]
        public void searchCoursesByAllCourseLevelTest()
        {
            controller = new Controllers.HomeController();

            List<string> emptyList = new List<string>();

            List<string> courseLevels = new List<string>();
            courseLevels.Add("All");

            controller.CourseResults(emptyList, emptyList, emptyList, courseLevels, emptyList, "", "", "1", "10", null, null, null, null, null, null, null);

            // Compare values for all courses
            Assert.Equal(20, controller.ViewBag.Courses.Count);

            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse1(), controller.ViewBag.Courses[0]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse2(), controller.ViewBag.Courses[1]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse3(), controller.ViewBag.Courses[2]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse4(), controller.ViewBag.Courses[3]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse5(), controller.ViewBag.Courses[4]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse6(), controller.ViewBag.Courses[5]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse7(), controller.ViewBag.Courses[6]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse8(), controller.ViewBag.Courses[7]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse9(), controller.ViewBag.Courses[8]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse10(), controller.ViewBag.Courses[9]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse11(), controller.ViewBag.Courses[10]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse12(), controller.ViewBag.Courses[11]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse13(), controller.ViewBag.Courses[12]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse14(), controller.ViewBag.Courses[13]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse15(), controller.ViewBag.Courses[14]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse16(), controller.ViewBag.Courses[15]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse17(), controller.ViewBag.Courses[16]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse18(), controller.ViewBag.Courses[17]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse19(), controller.ViewBag.Courses[18]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse20(), controller.ViewBag.Courses[19]);
        }

        // Searching courses by choosing Dental for the Course Level should return no courses 
        [Fact]
        public void searchCoursesByDentalCourseLevelTest()
        {
            controller = new Controllers.HomeController();

            List<string> emptyList = new List<string>();

            List<string> courseLevels = new List<string>();
            courseLevels.Add("Dental");

            controller.CourseResults(emptyList, emptyList, emptyList, courseLevels, emptyList, "", "", "1", "10", null, null, null, null, null, null, null);

            // Should return no courses
            Assert.Equal(0, controller.ViewBag.Courses.Count);
        }

        // Searching courses by choosing Graduate for the Course Level should return only Software Engineering, and (listed as Undergraduate and Graduate) Calculus I and Statistics for Business courses 
        [Fact]
        public void searchCoursesByGraduateCourseLevelTest()
        {
            controller = new Controllers.HomeController();

            List<string> emptyList = new List<string>();

            List<string> courseLevels = new List<string>();
            courseLevels.Add("Graduate");

            controller.CourseResults(emptyList, emptyList, emptyList, courseLevels, emptyList, "", "", "1", "10", null, null, null, null, null, null, null);

            // Compare values for all courses
            Assert.Equal(9, controller.ViewBag.Courses.Count);

            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse1(), controller.ViewBag.Courses[0]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse2(), controller.ViewBag.Courses[1]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse3(), controller.ViewBag.Courses[2]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse4(), controller.ViewBag.Courses[3]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse5(), controller.ViewBag.Courses[4]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse13(), controller.ViewBag.Courses[5]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse14(), controller.ViewBag.Courses[6]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse16(), controller.ViewBag.Courses[7]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse17(), controller.ViewBag.Courses[8]);
        }

        // Searching courses by choosing Professional (Doctorate/CAS) for the Course Level should only two Software Engineering courses 
        [Fact]
        public void searchCoursesByProfessionalCourseLevelTest()
        {
            controller = new Controllers.HomeController();

            List<string> emptyList = new List<string>();

            List<string> courseLevels = new List<string>();
            courseLevels.Add("Professional (Doctorate/CAS)");

            controller.CourseResults(emptyList, emptyList, emptyList, courseLevels, emptyList, "", "", "1", "10", null, null, null, null, null, null, null);

            // Compare values for all courses
            Assert.Equal(2, controller.ViewBag.Courses.Count);

            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse1(), controller.ViewBag.Courses[0]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse2(), controller.ViewBag.Courses[1]);
        }

        // Searching courses by choosing Undergraduate for the Course Level should only Undergraduate courses 
        [Fact]
        public void searchCoursesByUndergraduateCourseLevelTest()
        {
            controller = new Controllers.HomeController();

            List<string> emptyList = new List<string>();

            List<string> courseLevels = new List<string>();
            courseLevels.Add("Undergraduate");

            controller.CourseResults(emptyList, emptyList, emptyList, courseLevels, emptyList, "", "", "1", "10", null, null, null, null, null, null, null);

            // Compare values for all courses
            Assert.Equal(15, controller.ViewBag.Courses.Count);

            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse6(), controller.ViewBag.Courses[0]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse7(), controller.ViewBag.Courses[1]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse8(), controller.ViewBag.Courses[2]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse9(), controller.ViewBag.Courses[3]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse10(), controller.ViewBag.Courses[4]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse11(), controller.ViewBag.Courses[5]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse12(), controller.ViewBag.Courses[6]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse13(), controller.ViewBag.Courses[7]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse14(), controller.ViewBag.Courses[8]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse15(), controller.ViewBag.Courses[9]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse16(), controller.ViewBag.Courses[10]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse17(), controller.ViewBag.Courses[11]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse18(), controller.ViewBag.Courses[12]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse19(), controller.ViewBag.Courses[13]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse20(), controller.ViewBag.Courses[14]);
        }
    }
}
