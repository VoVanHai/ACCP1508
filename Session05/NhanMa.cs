using System;

namespace Session05
{
    public class NhanMa : Animal, IHuman
    {
        public override void speak()
        {
            Console.WriteLine("human speaking");
        }

        public void thinking()
        {
            Console.WriteLine("human thinking");
        }
    }
}
