using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01
{
    class Test
    {
        const double PI = 3.14d;
        public static void Main(string[] args)
        {
            int a ,b;
            Console.Write("nhập số a=");
            a = int.Parse(Console.ReadLine());
            //a = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhập số b=");
            b = Convert.ToInt32(Console.ReadLine());
            int c = cong(a,b);

            Console.WriteLine(a+" + "+b+" = "+c);
            Console.WriteLine("{0} + {1} = {2}",a,b,c);
            Console.ReadLine();

        }
        /// <summary>
        /// phương thức cộng 2 số
        /// </summary>
        /// <param name="a">là số thứ nhất</param>
        /// <param name="b">là số thứ hai</param>
        /// <returns>tổng hai số</returns>
        public static int cong(int a, int b)
        {
            return a + b;
        }
    }
}
