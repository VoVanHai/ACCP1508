namespace Baitap
{
    class Program
    {
        static void Main(string[] args)
        {
            SachGK s1 = new SachGK();
            s1.Masach = 10101;
            s1.NgayNhap = new KieuNgay(13, 6, 2015);
            s1.NhaXB = "NXB Tao Lao";
            s1.Soluong = 100;
            s1.Dongia = 20000d;
            s1.Tinhtrang = "cu";

            System.Console.WriteLine(s1);

            System.Console.ReadKey();
        }
    }
}
