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

            //kiểm tra kiểu nullable có giá trị chưa
            if(number.HasValue)
                Console.WriteLine(number);
            else
                Console.WriteLine("number has no value");

            Console.ReadKey();
        }
    }
}
