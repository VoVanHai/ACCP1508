using System;

namespace Session05
{
    public abstract class Animal
    {
        public string Name { get; set; }

        public void eat()
        {
            Console.WriteLine("Animal eating...");
        }

        public abstract void speak();
    }
}
