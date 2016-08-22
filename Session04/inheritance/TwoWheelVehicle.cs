using System;

namespace Session04.inheritance
{
    public class TwoWheelVehicle:Vehicle
    {
        public TwoWheelVehicle(string date) : base(date)
        {
        }

        void abc()
        {
            doFOoo();
            run();
            base.run();
           
        }
        public sealed override void run()
        {
            Console.WriteLine("Bike is running...");
        }
    }
}
