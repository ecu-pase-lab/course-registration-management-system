using System;
using System.Collections.Generic;
using CourseRegistrationManagementSystem.Models;
using Xunit;

namespace CourseRegistrationManagementSystem.Tests
{
    public class InstructorTests
    {
        private Controllers.HomeController controller;

        // Choosing Mark Hills in the Instructor drop-down menu should return only courses that Mark Hills teaches 
        [Fact]
        public void searchCoursesByInstructorTest()
        {
            controller = new Controllers.HomeController();

            List<string> emptyList = new List<string>();

            string instructors = "Mark Hills, ";

            controller.CourseResults(emptyList, emptyList, instructors, emptyList, emptyList, emptyList, "", "", "1", "10", null, null, null, null, null, null, null, null, null);

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

            string instructors = "Mark Hills, Qin Ding, ";

            controller.CourseResults(emptyList, emptyList, instructors, emptyList, emptyList, emptyList, "", "", "1", "10", null, null, null, null, null, null, null, null, null);

            // Compare values for all courses
            Assert.Equal(2, controller.ViewBag.Courses.Count);

            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse1(), controller.ViewBag.Courses[0]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse10(), controller.ViewBag.Courses[1]);
        }

        // Choosing Mark Hills three times in the Instructor drop-down menu should return only courses that Mark Hills teaches, and not display duplicate courses
        [Fact]
        public void searchCoursesByInstructorRemoveDuplicatesTest()
        {
            controller = new Controllers.HomeController();

            List<string> emptyList = new List<string>();

            string instructors = "Mark Hills, Mark Hills, Mark Hills, ";

            controller.CourseResults(emptyList, emptyList, instructors, emptyList, emptyList, emptyList, "", "", "1", "10", null, null, null, null, null, null, null, null, null);

            // Compare values for course
            Assert.Equal(1, controller.ViewBag.Courses.Count);

            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse1(), controller.ViewBag.Courses[0]);
        }
    }
}
