using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03
{
    class TestMatrix
    {
        public static void Main(String[] args)
        {
            demoRectangularArray();
        }
        public static void demoRectangularArray()
        {
            Random rnd = new Random();
            int[,] a = new int[3, 4];
            Console.WriteLine("so phan tu cua mang la {0}", a.Length);
            for (int i = 0; i < a.GetLength(0)/*số dòng*/; i++)
            {
                for (int j = 0; j < a.GetLength(1)/*số cột*/; j++)
                {
                    a[i,j] = rnd.Next(50);
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(a[i,j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        public static void demoJaggedArray()
        {
            int[][] a = new int[3][];
            a[0] = new int[3];
            a[1] = new int[1];
            a[2] = new int[4];
            Random rnd = new Random();

            for (int i = 0; i < a.Length/*số dòng=3*/; i++)
            {
                for (int j = 0; j < a[i].Length/*độ dài của mỗi dòng*/; j++)
                {
                    a[i][j] = rnd.Next(50);
                }
            }
            for (int i = 0; i < a.Length/*số dòng=3*/; i++)
            {
                for (int j = 0; j < a[j].Length/*độ dài của mỗi dòng*/; j++)
                {
                    Console.Write(a[i][j]+"\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
