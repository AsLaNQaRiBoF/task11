using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Bicycle : Vehicle, IWheel, ITransmission
    {
        private string _pedalKind;

        public string PedalKind
        { get; set; }
        private double _wheelThickness;
        public double WheelThickness
        { get; set; }
        private string _transmissionKind;

        public string TransmissionKind
        { get; set; }
    }
}



