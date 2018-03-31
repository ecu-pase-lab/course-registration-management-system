﻿/**
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
    public class DirectionsTests
    {
        private Controllers.HomeController controller;

        // Passing strings for two courses (generated by schedule screen) should parse the classroom name, latitude, and longitude from the strings for both courses
        [Fact]
        public void searchCoursesByMainCampusTest()
        {
            controller = new Controllers.HomeController();

            //controller.Directions("", "");

            //// Compare values for all courses
            //Assert.Equal(1, controller.ViewBag.ClassroomName1.Count);
            //Assert.Equal(1, controller.ViewBag.ClassroomLatitude1.Count);
            //Assert.Equal(1, controller.ViewBag.ClassroomLongitude1.Count);
            //Assert.Equal(1, controller.ViewBag.ClassroomName2.Count);
            //Assert.Equal(1, controller.ViewBag.ClassroomLatitude2.Count);
            //Assert.Equal(1, controller.ViewBag.ClassroomLongitude2.Count);

            //CourseTestUtils.checkCoursePropertiesAreEqual(MockCRMSData.createCourse1(), controller.ViewBag.Courses[0]);
       
        }
    }
}
