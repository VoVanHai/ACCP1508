using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session08_02
{
    class LambdaStandardOps
    {
        public static void Main(string[] rags)
        {
            string[] items = {
                "ty","teo","men","coi","det"
            };
            foreach (var item in items.OrderByDescending(name=>name))
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
