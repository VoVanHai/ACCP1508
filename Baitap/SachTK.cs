namespace Baitap
{
    public class SachTK:Sach
    {
        public double Thue { get; set; }

        public override double tinhtien()
        {
            return Soluong * Dongia + Thue;
        }
    }
}
