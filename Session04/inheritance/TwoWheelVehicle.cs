using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
