namespace Baitap
{
    public class SachGK : Sach
    {
        public string Tinhtrang { get; set; }
        public override double tinhtien()
        {
            if (Tinhtrang.Equals("moi"))
                return Soluong * Dongia;
            return Soluong * Dongia * 0.5;
        }


        public override string ToString()
        {
            return base.ToString()+" - Tong tien = "+tinhtien();
        }
    }
}
