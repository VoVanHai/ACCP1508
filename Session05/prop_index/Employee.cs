using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session05.prop_index
{
    public class Employee
    {
        private string[] names ={"teo","ty","det","men"};
        public string this[int index]
        {
            get
            {
                if (index > names.Length - 1)
                    return null;
                return names[index];
            }
            set
            {
                if (index < names.Length && index>=0)
                    names[index] = value;
            }
        }

        public static void Main(String[] args)
        {
            Employee emp = new Employee();
            emp[6] = "nguyen van teo";
            string name = emp[10];

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(emp[i]);
            }

            Console.ReadKey();
        }
    }
}
