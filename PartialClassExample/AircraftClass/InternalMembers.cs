namespace PartialClassExample.AircraftClass
{
    partial class Aircraft
    {
        private void makeUpper() 
        {
            brand = brand.ToUpper();
            minorModel = minorModel.ToUpper();
            majorModel = majorModel.ToUpper();
        }
    }
}
