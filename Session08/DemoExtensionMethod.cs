using System;

namespace Session08
{
    public static class DemoExtensionMethod
    {
        //định  nghĩa thêm phương thức cho một đối tượng
        static string LamGiDo(this string s)
        {
            return s.ToUpper();
        }
        static string Left(this string s, int len)
        {
            string kq = "";
            for (int i = 0; i < len; i++)
            {
                kq += s[i];
            }
            return kq;
        }
        public static void Main(string[] args)
        {
            string s = "test";
            string kq=s.LamGiDo();
            Console.WriteLine(kq);
            s = "whose is the dog?";
            kq = s.Left(5);
            Console.WriteLine(kq);
            Console.ReadKey();
        }
    }
}
