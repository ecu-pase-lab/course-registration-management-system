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
    public class DirectionsTests
    {
        private Controllers.HomeController controller;

        // Passing strings with information for two courses (Software Construction and Public Speaking, passed from the schedule screen) 
        // should parse the classroom name, latitude, and longitude from the strings for both courses
        [Fact]
        public void parseDirectionsForCoursesTest()
        {
            controller = new Controllers.HomeController();

            // Software Construction is held in Brewster Building, Public Speaking is held in Joyner East
            controller.Directions("Brewster Building 0B204,35.6047775,-77.362346", "Joyner East 00214,35.6068811,-77.3675049");

            // Compare values for all courses
            Assert.Equal("Brewster Building 0B204", controller.ViewBag.ClassroomName1);
            Assert.Equal(35.6047775, controller.ViewBag.ClassroomLatitude1);
            Assert.Equal(-77.362346, controller.ViewBag.ClassroomLongitude1);
            Assert.Equal("Joyner East 00214", controller.ViewBag.ClassroomName2);
            Assert.Equal(35.6068811, controller.ViewBag.ClassroomLatitude2);
            Assert.Equal(-77.3675049, controller.ViewBag.ClassroomLongitude2);
        }
    }
}
