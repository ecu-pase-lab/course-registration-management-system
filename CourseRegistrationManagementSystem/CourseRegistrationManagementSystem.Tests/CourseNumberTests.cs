/**
 * Copyright 2018
 * James Adams IV
 * East Carolina University
 */

using System;
using System.Collections.Generic;
using CourseRegistrationManagementSystem.Models;
using Xunit;

namespace CourseRegistrationManagementSystem.Tests
{
    public class CourseNumberTests
    {
        private Controllers.HomeController controller;

        // Typing in 6230 in the Course Number search field should return only the SENG 6230 course
        [Fact]
        public void searchCoursesByCourseNumberTest()
        {
            controller = new Controllers.HomeController();

            List<string> emptyList = new List<string>();

            controller.CourseResults(emptyList, emptyList, null, emptyList, emptyList, emptyList, "", "6230", "1", "10", null, null, null, null, null, null, null, null, null);

            // Compare values for course
            Assert.Equal(1, controller.ViewBag.Courses.Count);

            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse1(), controller.ViewBag.Courses[0]);
        }

        // Typing in 21 in the Course Number search field should return three Calculus courses (from course numbers 2171 and 2172)
        [Fact]
        public void searchCoursesByPartialCourseNumberTest()
        {
            controller = new Controllers.HomeController();

            List<string> emptyList = new List<string>();

            controller.CourseResults(emptyList, emptyList, null, emptyList, emptyList, emptyList, "", "21", "1", "10", null, null, null, null, null, null, null, null, null);

            // Compare values for all courses
            Assert.Equal(3, controller.ViewBag.Courses.Count);

            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse13(), controller.ViewBag.Courses[0]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse14(), controller.ViewBag.Courses[1]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse15(), controller.ViewBag.Courses[2]);
        }

        // Typing in 8000 in the Course Number search field should return no courses
        [Fact]
        public void searchCoursesByInvalidCourseNumberTest()
        {
            controller = new Controllers.HomeController();

            List<string> emptyList = new List<string>();

            controller.CourseResults(emptyList, emptyList, null, emptyList, emptyList, emptyList, "", "8000", "1", "10", null, null, null, null, null, null, null, null, null);

            // Should return no courses
            Assert.Equal(0, controller.ViewBag.Courses.Count);
        }
    }
}
