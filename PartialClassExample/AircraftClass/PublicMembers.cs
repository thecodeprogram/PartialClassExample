using System;

namespace PartialClassExample.AircraftClass
{
    partial class Aircraft
    {
        public Aircraft() { }

        public void setAC(string _brand, string _majorModel, string _minorModel)
        {
            this.brand = _brand;
            this.majorModel = _majorModel;
            this.minorModel = _minorModel;
        }

        public void printUpperAC()
        {
            makeUpper();
            Console.WriteLine(acToString());
        }
    }
}
