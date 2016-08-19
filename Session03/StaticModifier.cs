using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
