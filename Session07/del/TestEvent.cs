using System;

namespace Session07.del
{
    //khai báo 1 delegate để trỏ đến phương thức Print sau này
    public delegate void PrintDelegate();
    public class TestEvent
    {
        //tạo 1 event
        public event PrintDelegate Print;   
        public static void Main(string[] args)
        {
            TestEvent te = new del.TestEvent();
            //đăng ký sự kiện 
            te.Print += PrintIt;
            //đk sự kiện 
            te.Print += new PrintDelegate(te.DoPrint) ;

            //sự kiện xảy ra
            te.Print();

            Console.ReadKey();
        }
        static void PrintIt()
        {
            Console.WriteLine("Printing document...");
        }
        void DoPrint()
        {
            Console.WriteLine("Printing document...");
        }
    }
}
