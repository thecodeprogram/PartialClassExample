namespace PartialClassExample.AircraftClass
{
    partial class Aircraft
    {
        private string brand = "Boeing";
        private string majorModel = "777";
        private string minorModel = "300ER";

        public string acToString() => brand + " " + majorModel + "-" + minorModel;
    }
}
