using System;

namespace Session08
{
    class DemoNullableType
    {
        static void Main(string[] args)
        {
            //kiểu nullable
            int? number=null;
            //.....
            //number = 10;
            //....

            //nếu number có giá trị thì gán giá trị của number cho x 
            //còn không gán 0.0 cho x
            double x = number ?? 0.0;

            //kiểm tra kiểu nullable có giá trị chưa
            if(number.HasValue)
                Console.WriteLine(number);
            else
                Console.WriteLine("number has no value");

            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
