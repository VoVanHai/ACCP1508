using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session04.inheritance
{
    class Test
    {
        public static void Main(string[] args)
        {
            Vehicle v = null;


            v = new TwoWheelVehicle("");
            v.run();

            v = new FourWheelVehicle(">>>>");
            v.run();

            Console.ReadKey();
        }
    }
}
