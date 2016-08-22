using System;

namespace Session03
{
    class DemoStatic
    {
        public static void Main(String[] args)
        {
            StaticModifier.doFoo();
            StaticModifier s1 = new StaticModifier();
            StaticModifier s2 = new StaticModifier();
            s1.doBar();

            StaticModifier.Rate = 100;
            s1.Something = 3;

            s1.doBar();
            s2.doBar();
            Console.ReadKey();
        }
    }
}
