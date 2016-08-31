namespace Baitap
{
    public abstract class Sach
    {
        public long Masach { get; set; }
        public KieuNgay NgayNhap { get; set; }
        public double Dongia { get; set; }
        public int Soluong { get; set; }
        public string NhaXB { get; set; }

        public abstract double tinhtien();

        public override string ToString()
        {
            return Masach + " - " + NhaXB + " - " + NgayNhap + " - " + Dongia +
                " - " + Soluong;
        }
    }
}
