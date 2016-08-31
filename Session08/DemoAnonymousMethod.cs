using System;


namespace Session08
{
    class DemoAnonymousMethod
    {
        delegate void Display();
        delegate void Print(string message, int value);
        public static void doPrint()
        {
            Console.WriteLine("hello moto");
        }
        public static void Main(string[] args)
        {
            //dùng delegate gọi phương thức có tên là doPrint
            Display dis = new Display(doPrint);
            dis();
            //dùng delegate gọi phương thức vô danh
            Display d = delegate ()
            {
                Console.WriteLine("hello kitty");
            };
            d();
            //...

            Print p = delegate (string msg, int val)
              {
                  Console.WriteLine(msg + ":" + val);
              };
            int value = 100;
            p("Fast iterest is ", value);

            Console.ReadKey();
        }
    }
}
