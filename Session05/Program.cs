using System;

namespace Session05
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = null;

            a = new Dog();
            a.speak();

            a = new Cat();
            a.speak();

            NhanMa nm = new NhanMa();
            nm.speak();
            nm.thinking();


            Console.ReadKey();

        }
    }
}
