using System;

namespace Session04.inheritance
{
    public class Vehicle
    {
        public Vehicle(string date)
        {
            //....
            run();
        }
        public virtual void run()
        {
            Console.WriteLine("vehicle is running...");
        }
        
        protected void doFOoo()
        {
            Console.WriteLine("foooooo");
            
        }

        public  void makeBy()
        {

        }
    }
}
