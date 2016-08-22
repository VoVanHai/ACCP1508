using System;

namespace Session01
{
    class Ex01
    {
        public static void Main(string[] args)
        {
            double d = 3.9999;
            double d1 = 123456789;
            Console.WriteLine("{0:#,###.#0}", d);
            Console.WriteLine("{0:N}",d1);
            int x = 345;
            Console.WriteLine("{0:X}",x);
            Console.ReadLine();
        }
    }
}
