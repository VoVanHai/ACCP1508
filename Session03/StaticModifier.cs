using System;

namespace Session03
{
    public class StaticModifier
    {
        public static int Rate = 0;
        public int Something = 0;


        public static void doFoo()
        {
            Console.WriteLine("foooooo");
        }

        public void doBar()
        {
            Console.WriteLine("bar: "+Rate+" - "+Something);
        }
    }
}
