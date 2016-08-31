using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session08_02
{
    class Program
    {
        delegate int Input(string s);
        static void Main(string[] args)
        {
            string words = "test lambda";
            //1. dùng anonymous method
            Input len = delegate (string s)
            {
                return s.Length;
            };
            //2. dùng lambda expression
            Input y = (x => x.Length);
            //1 tương đương 2
            Console.WriteLine(len(words));
            Console.WriteLine(y(words));
            Console.ReadKey();
        }
    }
}
