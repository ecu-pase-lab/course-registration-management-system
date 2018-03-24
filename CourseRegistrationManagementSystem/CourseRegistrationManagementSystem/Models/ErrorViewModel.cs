/**
 * Copyright 2018
 * James Adams IV
 * East Carolina University
 */

using System;

namespace CourseRegistrationManagementSystem.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}