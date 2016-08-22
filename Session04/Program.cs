using System;

namespace teo
{
    class Program
    {

        private string name;

        public String Name { get; set; }

        static Program()
        {
            //khởi tạo các dữ liệu chỉ chạy 1 lần
            Console.WriteLine("static constructor được gọi");
        }

        //default ~ parameterless constaructor
        Program():this("noname")
        {
            Console.WriteLine("hàm constructor được gọi");
            //name = "noname";
        }

        Program(string name)//parameterize constructor
        {
            this.name = name;
        }

        ~Program()
        {
            //hàm này được chạy khi đối tượng bị hủy
            Console.WriteLine("hủy đối tượng");
        }

        public void setName(string name)
        {
            this.name = name;
        }

        void swap(ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        void test(out int a)
        {
            int b = 100;
            a=b;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            //int x = 5, y=0 ;
            //Console.WriteLine("x={0}\ty={1}", x, y);
            //p.swap(ref x, ref y);
            //Console.WriteLine("x={0}\ty={1}",x,y);
            int x;
            p.test(out x);
            Console.WriteLine(x);

            Program p1 = new Program();

            p = null;
            

            Program p2 = new Program();
            Console.ReadKey();
            Console.ReadKey();


        }
    }
}
