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
    public class CampusTests
    {
        private Controllers.HomeController controller;

        // Searching courses by choosing Main Campus should return all courses taught in-person
        [Fact]
        public void searchCoursesByMainCampusTest()
        {
            controller = new Controllers.HomeController();

            List<string> emptyList = new List<string>();

            List<string> campuses = new List<string>();
            campuses.Add("Main Campus");

            controller.CourseResults(emptyList, campuses, null, emptyList, emptyList, emptyList, "", "", "1", "10", null, null, null, null, null, null, null, null, null);

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

            controller.CourseResults(emptyList, campuses, null, emptyList, emptyList, emptyList, "", "", "1", "10", null, null, null, null, null, null, null, null, null);

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

            controller.CourseResults(emptyList, campuses, null, emptyList, emptyList, emptyList, "", "", "1", "10", null, null, null, null, null, null, null, null, null);

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

        // Searching courses by choosing Main Campus and DE/Internet Campus for Campus should return both courses taught in-person and online
        // This test should return the same results as selecting All for Campus
        [Fact]
        public void searchCoursesByMainAndDECampusTest()
        {
            controller = new Controllers.HomeController();

            List<string> emptyList = new List<string>();

            List<string> campuses = new List<string>();
            campuses.Add("Main Campus");
            campuses.Add("DE/Internet Campus");

            controller.CourseResults(emptyList, campuses, null, emptyList, emptyList, emptyList, "", "", "1", "10", null, null, null, null, null, null, null, null, null);

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
    }
}
