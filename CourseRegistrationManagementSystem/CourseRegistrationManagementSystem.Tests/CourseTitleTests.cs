using System;
using System.Collections.Generic;
using CourseRegistrationManagementSystem.Models;
using Xunit;

namespace CourseRegistrationManagementSystem.Tests
{
    public class CourseTitleTests
    {
        private Controllers.HomeController controller;

        // Typing in Physics in the Course Title search field should only return courses with Physics in the course name
        [Fact]
        public void searchCoursesByCourseTitleTest()
        {
            controller = new Controllers.HomeController();

            List<string> emptyList = new List<string>();

            controller.CourseResults(emptyList, emptyList, emptyList, emptyList, emptyList, emptyList, "Physics", "", "1", "10", null, null, null, null, null, null, null, null, null);

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

            controller.CourseResults(emptyList, emptyList, emptyList, emptyList, emptyList, emptyList, "Calc", "", "1", "10", null, null, null, null, null, null, null, null, null);

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

            controller.CourseResults(emptyList, emptyList, emptyList, emptyList, emptyList, emptyList, "History", "", "1", "10", null, null, null, null, null, null, null, null, null);

            // Should return no courses
            Assert.Equal(0, controller.ViewBag.Courses.Count);
        }
    }
}
