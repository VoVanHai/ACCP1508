using System;

namespace Session08
{
    public class DemoAnonymousType
    {
        public static void Main(string[] args)
        {
            //kiểu vô danh
            var emp = new
            {
                FirstName = "nguyen van",
                LastName = "teo",
                Address = "768 Nguyen Kiem, GV"
            };

            Console.WriteLine(emp.FirstName);
            Console.WriteLine(emp.LastName);
            Console.WriteLine(emp.Address);

            Console.ReadKey();
        }
    }
}
