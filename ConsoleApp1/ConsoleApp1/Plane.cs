using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Plane :Vehicle , IEngine, IWheel , ITransmission
{
	private int _wingLength;

        public int Winglength
        {get;set;}
        private double _horsePower;
        public double HorsePower

        { get;set;}
        private double _tankSize;
        public double TankSize
        {get;set;}
        private double _currentOil;
        public double CurrentOil
        {get;set;}
        private string _fuelType;
        public string FuelType
        { get; set; }
           
        private double _wheelThickness;
        public double WheelThickness
        {get;set;}
        private string _transmissionKind;
        public string TransmissionKind
        {get;set}

        public double RemainOilAmount(double tankSize, double currentOil)
        {
            return (tankSize - currentOil);
        }
    }
