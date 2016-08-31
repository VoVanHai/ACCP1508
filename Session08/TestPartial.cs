using System;

namespace Session08
{
    class TestPartial
    {
        static void Main(string[] args)
        {
            Student st = new Session08.Student(100, "Than thi det");
            st.FullName = "Tran thi men";
            st.PrintInfos();

            Console.ReadKey();
        }
    }
}
