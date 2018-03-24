/**
 * Copyright 2018
 * James Adams IV
 * East Carolina University
 */

using System.Collections.Generic;
using CourseRegistrationManagementSystem.Models;
using Xunit;
using Moq;
using Microsoft.AspNetCore.Mvc;

namespace CourseRegistrationManagementSystem.Tests
{
    public class AddAndRemoveFromScheduleTests
    {
        private Controllers.HomeController controller;

        // Searching courses by choosing Main Campus should return all courses taught in-person
        [Fact]
        public void addCourseToScheduleTest()
        {
            controller = new Controllers.HomeController();

            //controller.AddCourseToSchedule(3);

            //List<Course> scheduledCourses = controller.HttpContext.Session.Get<List<Course>>("scheduledCourses");

            // Compare values for course
            //Assert.Equal(1, scheduledCourses.Count);

            //CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse3(), scheduledCourses[0]);

            //List<Course> scheduledCourses = new List<Course>();
            //scheduledCourses.Add(MockCRMSData.createCourse3());

            //var mockControllerContext = new Mock<ControllerContext>();
            //var mockSession = new Mock<Microsoft.AspNetCore.Http.HttpContext.Session>();
            //mockSession.SetupGet(s => s["scheduledCourses"]).Returns(scheduledCourses); //somevalue
            //mockControllerContext.Setup(p => p.HttpContext.Session).Returns(mockSession.Object);

            //controller.ControllerContext = mockControllerContext.Object;

            ////Act         
            //controller.AddCourseToSchedule(3);
    
        }
    }
}
