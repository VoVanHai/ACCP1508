using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session08_02
{
    class TestLinq
    {
        public static void Main(string[] rags)
        {
            string[] items = {
                "ty","teo","men","coi","det","tam"
            };
            //dùng lambda
            var kq1 = items.Where(name => name.StartsWith("t"));
            //dùng query
            var kq = from item in items
                     where item.StartsWith("t")
                     select item;
            
            foreach (var item in kq)
            {
                Console.WriteLine(item);
            }

           

            Console.ReadKey();
        }
    }
}
