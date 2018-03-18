using System;
using System.Collections.Generic;
using CourseRegistrationManagementSystem.Models;
using Xunit;

namespace CourseRegistrationManagementSystem.Tests
{
    public class SubjectTests
    {
        private Controllers.HomeController controller;

        // Choosing Mathematics in the Subject drop-down menu should return only courses in that Subject
        [Fact]
        public void searchCoursesBySubjectTest()
        {
            controller = new Controllers.HomeController();

            List<string> emptyList = new List<string>();

            List<string> subjects = new List<string>();
            subjects.Add("Mathematics");

            controller.CourseResults(subjects, emptyList, emptyList, emptyList, emptyList, emptyList, "", "", "1", "10", null, null, null, null, null, null, null, null, null);

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

            controller.CourseResults(subjects, emptyList, emptyList, emptyList, emptyList, emptyList, "", "", "1", "10", null, null, null, null, null, null, null, null, null);

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

        // Choosing All in the Subject drop-down menu should return courses in every Subject
        [Fact]
        public void searchCoursesByAllSubjectTest()
        {
            controller = new Controllers.HomeController();

            List<string> emptyList = new List<string>();

            List<string> subjects = new List<string>();
            subjects.Add("All");

            controller.CourseResults(subjects, emptyList, emptyList, emptyList, emptyList, emptyList, "", "", "1", "10", null, null, null, null, null, null, null, null, null);

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
