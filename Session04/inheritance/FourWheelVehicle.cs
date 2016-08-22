using System;

namespace Session04.inheritance
{
    public class FourWheelVehicle : Vehicle
    {
        public FourWheelVehicle(string date) : base(date)
        {
           
        }
        public override void run()
        {
            Console.WriteLine("Four wheels running,....");
        }
    }
}
