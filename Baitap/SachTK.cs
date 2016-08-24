using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
