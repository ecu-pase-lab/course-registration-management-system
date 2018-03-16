using System;
using CourseRegistrationManagementSystem.Models;
using Xunit;

namespace CourseRegistrationManagementSystem.Tests
{
    public static class CourseTestUtils
    {
        // Helper method to check that each property of two Course objects are equal
        public static void checkCoursePropertiesAreEqual(Course expectedCourse, Course actualCourse)
        {
            // Compare Course values
            Assert.Equal(expectedCourse.ID, actualCourse.ID);
            Assert.Equal(expectedCourse.CourseName, actualCourse.CourseName);
            Assert.Equal(expectedCourse.CourseRegistarCode, actualCourse.CourseRegistarCode);
            Assert.Equal(expectedCourse.CourseSubjectCode, actualCourse.CourseSubjectCode);
            Assert.Equal(expectedCourse.SectionNumber, actualCourse.SectionNumber);
            Assert.Equal(expectedCourse.Subject, actualCourse.Subject);
            Assert.Equal(expectedCourse.CourseTerm, actualCourse.CourseTerm);
            Assert.Equal(expectedCourse.RegistrationStartDate, actualCourse.RegistrationStartDate);
            Assert.Equal(expectedCourse.RegistrationEndDate, actualCourse.RegistrationEndDate);
            Assert.Equal(expectedCourse.ClassStartDate, actualCourse.ClassStartDate);
            Assert.Equal(expectedCourse.ClassEndDate, actualCourse.ClassEndDate);
            Assert.Equal(expectedCourse.ClassInstructionalMethod, actualCourse.ClassInstructionalMethod);
            Assert.Equal(expectedCourse.CreditHours, actualCourse.CreditHours);
            Assert.Equal(expectedCourse.InstructorName, actualCourse.InstructorName);
            Assert.Equal(expectedCourse.ClassroomNames, actualCourse.ClassroomNames);
            Assert.Equal(expectedCourse.CampusName, actualCourse.CampusName);
            Assert.Equal(expectedCourse.ClassDays, actualCourse.ClassDays);
            Assert.Equal(expectedCourse.ClassTimes, actualCourse.ClassTimes);
            Assert.Equal(expectedCourse.Prerequisites, actualCourse.Prerequisites);
            Assert.Equal(expectedCourse.TextbookName, actualCourse.TextbookName);
            Assert.Equal(expectedCourse.TextbookNewPrice, actualCourse.TextbookNewPrice);
            Assert.Equal(expectedCourse.TextbookUsedPrice, actualCourse.TextbookUsedPrice);
            Assert.Equal(expectedCourse.CourseLevels, actualCourse.CourseLevels);

            // Compare Seat values
            Assert.Equal(expectedCourse.CourseSeat.Capacity, actualCourse.CourseSeat.Capacity);
            Assert.Equal(expectedCourse.CourseSeat.Actual, actualCourse.CourseSeat.Actual);
            Assert.Equal(expectedCourse.CourseSeat.Remaining, actualCourse.CourseSeat.Remaining);
            Assert.Equal(expectedCourse.CourseSeat.WaitlistCapacity, actualCourse.CourseSeat.WaitlistCapacity);
            Assert.Equal(expectedCourse.CourseSeat.WaitlistActual, actualCourse.CourseSeat.WaitlistActual);
            Assert.Equal(expectedCourse.CourseSeat.WaitlistRemaining, actualCourse.CourseSeat.WaitlistRemaining);
        }
    }
}
