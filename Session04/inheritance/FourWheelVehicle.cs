using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
