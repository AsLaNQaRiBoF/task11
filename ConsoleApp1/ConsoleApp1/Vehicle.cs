using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal abstract class Vehicle
    {
        private double _driveTime;

        public double DriveTime
        { get; set; }

        private double _drivePath;

        public double DrivePath
        {
            get;set;
        }

        public double AverageSpeed(double drivePath, double driveTime)
        {
            return (drivePath / driveTime);
        }
    }
}
