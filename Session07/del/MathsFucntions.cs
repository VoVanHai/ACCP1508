using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session07.del
{
    public class MathsFucntions
    {
        public delegate int MathOps(int x, int y);

        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Subtract(int a, int b)
        {
            return a - b;
        }
        public void testDelegate()
        {
            MathOps m1 = new MathOps(Add);
            int kq1 = m1(6, 7);

            m1 = new MathOps(Subtract);
            int kq2 = m1(6, 7);

            Console.WriteLine(kq1);
            Console.WriteLine(kq2);
        }

        public static void Main(string[] args)
        {
            new MathsFucntions().testDelegate();
            Console.ReadKey();
        }
    }
}
