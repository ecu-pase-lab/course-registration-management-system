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
    public class ClassTimesTests
    {
        private Controllers.HomeController controller;

        // Searching courses by selecting a time range of 8:30 AM to 11:30 AM should return only courses that start at or after 8:30 AM and end by 11:30 AM 
        [Fact]
        public void searchCoursesByClassTimeAMToAM()
        {
            controller = new Controllers.HomeController();

            List<string> emptyList = new List<string>();

            controller.CourseResults(emptyList, emptyList, null, emptyList, emptyList, emptyList, "", "", "1", "10", null, null, null, null, null, null, null, "8 : 30 AM", "11 : 30 AM");

            // Compare values for all courses
            Assert.Equal(4, controller.ViewBag.Courses.Count);

            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse10(), controller.ViewBag.Courses[0]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse14(), controller.ViewBag.Courses[1]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse16(), controller.ViewBag.Courses[2]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse20(), controller.ViewBag.Courses[3]);
        }

        // Searching courses by selecting a time range of 11:00 AM to 3:00 PM should return only courses that start at or after 11:00 AM and end by 3:00 PM 
        [Fact]
        public void searchCoursesByClassTimeAMToPM()
        {
            controller = new Controllers.HomeController();

            List<string> emptyList = new List<string>();

            controller.CourseResults(emptyList, emptyList, null, emptyList, emptyList, emptyList, "", "", "1", "10", null, null, null, null, null, null, null, "11 : 00 AM", "3 : 00 PM");

            // Compare values for all courses
            Assert.Equal(7, controller.ViewBag.Courses.Count);

            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse2(), controller.ViewBag.Courses[0]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse3(), controller.ViewBag.Courses[1]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse6(), controller.ViewBag.Courses[2]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse7(), controller.ViewBag.Courses[3]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse13(), controller.ViewBag.Courses[4]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse18(), controller.ViewBag.Courses[5]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse19(), controller.ViewBag.Courses[6]);
        }

        // Searching courses by selecting a time range of 12:00 PM to 3:15 PM should return only courses that start at or after 12:00 PM and end by 3:15 PM 
        [Fact]
        public void searchCoursesByClassTimePMToPM()
        {
            controller = new Controllers.HomeController();

            List<string> emptyList = new List<string>();

            controller.CourseResults(emptyList, emptyList, null, emptyList, emptyList, emptyList, "", "", "1", "10", null, null, null, null, null, null, null, "12 : 00 PM", "3 : 15 PM");

            // Compare values for all courses
            Assert.Equal(8, controller.ViewBag.Courses.Count);

            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse1(), controller.ViewBag.Courses[0]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse2(), controller.ViewBag.Courses[1]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse4(), controller.ViewBag.Courses[2]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse5(), controller.ViewBag.Courses[3]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse6(), controller.ViewBag.Courses[4]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse7(), controller.ViewBag.Courses[5]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse18(), controller.ViewBag.Courses[6]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse19(), controller.ViewBag.Courses[7]);
        }

        // Searching courses by selecting a time range of 9:00 PM to 10:00 PM should return no courses. 
        // This test checks that PM is treated different than AM (since courses would be returned for this time range in AM).
        [Fact]
        public void searchCoursesByClassTimePMToPMReturnsNoCourses()
        {
            controller = new Controllers.HomeController();

            List<string> emptyList = new List<string>();

            controller.CourseResults(emptyList, emptyList, null, emptyList, emptyList, emptyList, "", "", "1", "10", null, null, null, null, null, null, null, "9 : 00 PM", "10 : 00 PM");

            // Should return no courses
            Assert.Equal(0, controller.ViewBag.Courses.Count);
        }

        // Searching courses in Physics subject and selecting a time range of 1:00 PM to 4:00 PM should return 2 Physics courses. 
        // This test checks that 1 of the courses is not displayed twice, since this course has two different meeting times for different days (both times fall within this range).
        [Fact]
        public void searchCoursesByClassTimeDoesNotReturnDuplicateCourses()
        {
            controller = new Controllers.HomeController();

            List<string> emptyList = new List<string>();

            List<string> subjects = new List<string>();
            subjects.Add("Physics");

            controller.CourseResults(subjects, emptyList, null, emptyList, emptyList, emptyList, "", "", "1", "10", null, null, null, null, null, null, null, "1 : 00 PM", "4 : 00 PM");

            // Compare values for course
            Assert.Equal(2, controller.ViewBag.Courses.Count);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse18(), controller.ViewBag.Courses[0]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse19(), controller.ViewBag.Courses[1]);
        }
    }
}
