using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap
{
    public class KieuNgay
    {
        public int Ngay { get; set; }
        public int Thang { get; set; }
        public int Nam { get; set; }
        public KieuNgay(int ngay, int thang,int nam)
        {
            Ngay = ngay;Thang = thang;Nam = nam;
        }

        public override string ToString()
        {
            return Ngay+"/"+Thang+"/"+Nam;
        }
    }
}
