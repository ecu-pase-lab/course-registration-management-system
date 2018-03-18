using System;
using System.Collections.Generic;
using CourseRegistrationManagementSystem.Models;
using Xunit;

namespace CourseRegistrationManagementSystem.Tests
{
    public class CreditHoursTests
    {
        private Controllers.HomeController controller;

        // Searching courses worth Credit hours of 1 to 2 should return only courses with 1 to 2 Credit hours 
        [Fact]
        public void searchCoursesByCreditHours1To2Returns1CourseTest()
        {
            controller = new Controllers.HomeController();

            List<string> emptyList = new List<string>();

            controller.CourseResults(emptyList, emptyList, null, emptyList, emptyList, emptyList, "", "", "1", "2", null, null, null, null, null, null, null, null, null);

            // Compare values for course
            Assert.Equal(1, controller.ViewBag.Courses.Count);

            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse20(), controller.ViewBag.Courses[0]);
        }

        // Searching courses worth Credit hours of 3 to 3 should return only courses worth 3 Credit hours
        [Fact]
        public void searchCoursesByCreditHours3To3ReturnsAll3HourCoursesTest()
        {
            controller = new Controllers.HomeController();

            List<string> emptyList = new List<string>();

            controller.CourseResults(emptyList, emptyList, null, emptyList, emptyList, emptyList, "", "", "3", "3", null, null, null, null, null, null, null, null, null);

            // Compare values for all courses
            Assert.Equal(14, controller.ViewBag.Courses.Count);

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
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse16(), controller.ViewBag.Courses[12]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse17(), controller.ViewBag.Courses[13]);
        }

        // Searching courses worth Credit hours of 4 to 5 should return only courses worth 4 Credit hours in this case
        [Fact]
        public void searchCoursesByCreditHours4To5ReturnsAll4HourCoursesTest()
        {
            controller = new Controllers.HomeController();

            List<string> emptyList = new List<string>();

            controller.CourseResults(emptyList, emptyList, null, emptyList, emptyList, emptyList, "", "", "4", "5", null, null, null, null, null, null, null, null, null);

            // Compare values for all courses
            Assert.Equal(5, controller.ViewBag.Courses.Count);

            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse13(), controller.ViewBag.Courses[0]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse14(), controller.ViewBag.Courses[1]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse15(), controller.ViewBag.Courses[2]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse18(), controller.ViewBag.Courses[3]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse19(), controller.ViewBag.Courses[4]);
        }

        // Searching courses worth Credit hours of 5 to 10 should return no courses 
        [Fact]
        public void searchCoursesByCreditHoursReturnsNoCoursesTest()
        {
            controller = new Controllers.HomeController();

            List<string> emptyList = new List<string>();

            controller.CourseResults(emptyList, emptyList, null, emptyList, emptyList, emptyList, "", "", "5", "10", null, null, null, null, null, null, null, null, null);

            // Should return no courses
            Assert.Equal(0, controller.ViewBag.Courses.Count);
        }
    }
}
