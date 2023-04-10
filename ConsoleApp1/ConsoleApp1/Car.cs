using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Car : Vehicle, IEngine, IWheel, ITransmission
    {
        private int _doorCount;

        public int DoorCount
        { get;set;}

        private string _winCode;

        public string WinCode
        {get;set;}
        private double _horsePower;
        public double HorsePower
        { get ;set;}
        private double _tankSize;
        public double TankSize
        {get ;set;}
        private double _currentOil;
        public double CurrentOil
        {get;set;}
        private string _fuelType;
        public string FuelType
        {get;set;}
        private double _wheelThickness;
        public double WheelThickness
        { get; set;}
        private string _transmissionKind;
        public string TransmissionKind
        {get; set; }
    }
}



