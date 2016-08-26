using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session06
{
    class TestRectangular
    {
        public static void Main(String[] args)
        {
            try
            {
                Rectangular r = new Rectangular(5, -4);
                Console.WriteLine(r.perimeter());
                Console.WriteLine(r.area());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
