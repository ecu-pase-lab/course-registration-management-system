/**
 * Copyright 2018
 * James Adams IV
 * East Carolina University
 */

using System;
namespace CourseRegistrationManagementSystem.Models
{
    public class GeoLocation
    {
        private double Latitude;
        private double Longitude;

        public GeoLocation()
        {
            
        }

        public GeoLocation(double Latitude, double Longitude)
        {
            this.Latitude = Latitude;
            this.Longitude = Longitude;
        }

        public double GetLatitude()
        {
            return Latitude;
        }

        public void SetLatitude(double value)
        {
            Latitude = value;
        }

        public double GetLongitude()
        {
            return Longitude;
        }

        public void SetLongitude(double value)
        {
            Longitude = value;
        }
    }
}
