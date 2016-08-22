using System;

namespace Session03
{
    public class ArrayDemo
    {
        public static void Main(String[] args)
        {
            //khai báo mảng
            int[] a;
            //cấp phát vùng nhớ
            a = new int[20];
            /*/-----------------------
            //vừa khai báo, vừa cấp phát vùng nhớ
            int[] b = new int[100];
            //-------------------------------
            //khởi tạo 1 mảng
            int[] c = { 4,3,6,2,7,4,6};
            //lấy độ lớn của mảng (số phần tử)
            int len = c.Length;
            
            string[] s = new string[10];
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write(s[i]+"\t");
            }
*/
         
            foreach (var x in a)
            {
                Console.Write(x + "\t");
            }

            Console.ReadKey();
        }
    }
}
