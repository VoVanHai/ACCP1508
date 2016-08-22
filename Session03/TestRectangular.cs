using System;

namespace Session03
{
    class TestRectangular
    {
        public static void Main(String[] args)
        {
            Rectangular r = new Rectangular(3, 4);
            double dt = r.area();
            Console.WriteLine(r);
            Console.WriteLine(dt);

            Rectangular_CS rc = new Rectangular_CS();
            rc.Width = 3;
            rc.Height = 4;
            Console.WriteLine(rc);
            Console.WriteLine(rc.area());

            Console.ReadKey();
        }
    }
}
