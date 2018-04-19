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
    public class ScheduleTypeTests
    {
        private Controllers.HomeController controller;

        // Choosing All in the Schedule Type drop-down menu should return all courses
        [Fact]
        public void searchCoursesByAllScheduleTypeTest()
        {
            controller = new Controllers.HomeController();

            List<string> emptyList = new List<string>();

            List<string> scheduleTypes = new List<string>();
            scheduleTypes.Add("All");

            controller.CourseResults(emptyList, emptyList, null, emptyList, emptyList, scheduleTypes, "", "", "1", "10", null, null, null, null, null, null, null, null, null);

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

        // Choosing Studio in the Schedule Type drop-down menu should return 1 Art course
        [Fact]
        public void searchCoursesByStudioScheduleTypeTest()
        {
            controller = new Controllers.HomeController();

            List<string> emptyList = new List<string>();

            List<string> scheduleTypes = new List<string>();
            scheduleTypes.Add("Studio");

            controller.CourseResults(emptyList, emptyList, null, emptyList, emptyList, scheduleTypes, "", "", "1", "10", null, null, null, null, null, null, null, null, null);

            // Compare values for course
            Assert.Equal(1, controller.ViewBag.Courses.Count);

            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse20(), controller.ViewBag.Courses[0]);
        }

        // Choosing Lecture in the Schedule Type drop-down menu should return courses with the Lecture Schedule Type
        [Fact]
        public void searchCoursesByLectureScheduleTypeTest()
        {
            controller = new Controllers.HomeController();

            List<string> emptyList = new List<string>();

            List<string> scheduleTypes = new List<string>();
            scheduleTypes.Add("Lecture");

            controller.CourseResults(emptyList, emptyList, null, emptyList, emptyList, scheduleTypes, "", "", "1", "10", null, null, null, null, null, null, null, null, null);

            // Compare values for all courses
            Assert.Equal(16, controller.ViewBag.Courses.Count);

            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse1(), controller.ViewBag.Courses[0]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse2(), controller.ViewBag.Courses[1]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse3(), controller.ViewBag.Courses[2]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse4(), controller.ViewBag.Courses[3]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse6(), controller.ViewBag.Courses[4]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse9(), controller.ViewBag.Courses[5]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse10(), controller.ViewBag.Courses[6]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse11(), controller.ViewBag.Courses[7]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse12(), controller.ViewBag.Courses[8]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse13(), controller.ViewBag.Courses[9]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse14(), controller.ViewBag.Courses[10]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse15(), controller.ViewBag.Courses[11]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse16(), controller.ViewBag.Courses[12]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse17(), controller.ViewBag.Courses[13]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse18(), controller.ViewBag.Courses[14]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse19(), controller.ViewBag.Courses[15]);
        }

        // Choosing Individual Study in the Schedule Type drop-down menu should return 1 DE course with the Individual Study Schedule Type
        [Fact]
        public void searchCoursesByIndividualStudyScheduleTypeTest()
        {
            controller = new Controllers.HomeController();

            List<string> emptyList = new List<string>();

            List<string> scheduleTypes = new List<string>();
            scheduleTypes.Add("Individual Study");

            controller.CourseResults(emptyList, emptyList, null, emptyList, emptyList, scheduleTypes, "", "", "1", "10", null, null, null, null, null, null, null, null, null);

            // Compare values for course
            Assert.Equal(1, controller.ViewBag.Courses.Count);

            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse5(), controller.ViewBag.Courses[0]);
        }

        // Choosing Lab in the Schedule Type drop-down menu should return 2 Algorithm Lab courses with the Lab Schedule Type
        [Fact]
        public void searchCoursesByLabScheduleTypeTest()
        {
            controller = new Controllers.HomeController();

            List<string> emptyList = new List<string>();

            List<string> scheduleTypes = new List<string>();
            scheduleTypes.Add("Lab");

            controller.CourseResults(emptyList, emptyList, null, emptyList, emptyList, scheduleTypes, "", "", "1", "10", null, null, null, null, null, null, null, null, null);

            // Compare values for course
            Assert.Equal(2, controller.ViewBag.Courses.Count);

            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse7(), controller.ViewBag.Courses[0]);
            CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse8(), controller.ViewBag.Courses[1]);
        }

        // Choosing Clinical in the Schedule Type drop-down menu should return no courses with the Clinical Schedule Type
        [Fact]
        public void searchCoursesByClinicalScheduleTypeTest()
        {
            controller = new Controllers.HomeController();

            List<string> emptyList = new List<string>();

            List<string> scheduleTypes = new List<string>();
            scheduleTypes.Add("Clinical");

            controller.CourseResults(emptyList, emptyList, null, emptyList, emptyList, scheduleTypes, "", "", "1", "10", null, null, null, null, null, null, null, null, null);

            // Should return no courses
            Assert.Equal(0, controller.ViewBag.Courses.Count);
        }
    }
}
