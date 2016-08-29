using System;
using System.Collections.Generic;

namespace Session07.collection
{
    class DemoColsGeneric
    {
        static void demoDictionary()
        {
            Dictionary<String, String> dic = new Dictionary<string, string>();
            dic.Add("k1", "than thi det");
            dic.Add("k2", "truong van tun");
            dic.Add("k3", "Tran van Teo");

            string s=dic["k2"];
            Console.WriteLine(s);
        }

        public static void Main(string[] args)
        {
            demoDictionary();
            Console.ReadKey();
        }
    }
}
