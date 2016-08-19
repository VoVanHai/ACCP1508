using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03
{
    public class BaitapMang
    {
        void nhapmang(ref int[] a)
        {
            Random rnd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(100);
            }
        }
        void xuatmang(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + "\t");
            }
        }
        void xuatMangNguoc(int[] a)
        {
            for (int i = a.Length - 1; i >= 0; i--)
            {
                Console.Write(a[i] + "\t");
            }
        }
        int tongPhantuCoGiatriChan(int[] a)
        {
            var tong = 0;
            foreach (var item in a)
            {
                if (item%2==0)
                {
                    tong += item;
                }
            }
            return tong;
        }
        void indDanhsachSont(int[] a)
        {
            foreach (var item in a)
            {
                if (ktnt(item))
                {
                    Console.Write(item+"\t");
                }
            }
        }

        private bool ktnt(int item)
        {
            if (item < 1) return false;
            for (int i = 2; i <= Math.Sqrt(item); i++)
            {
                if (item % i == 0) return false;
            }
            return true;
        }
        int demXuathien(int []a, int pt)
        {
            int dem = 0;
            foreach (var item in a)
            {
                if (item==pt)
                {
                    dem++;
                }
            }
            return dem;
        }

        //in ra phần tử có số lần xuất hiện nhiều nhất trong mảng
        public int getItemMaxOccurs(int[] a, ref int count)
        {
            int maxOcc = 0, maxItem=-1;
            for (int i = 0; i < a.Length; i++)
            {
                int oc = 0;
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[j] == a[i]) oc++;
                }
                if (oc > maxOcc)
                {
                    maxOcc = oc;
                    maxItem = a[i];
                }
            }
            count = maxOcc;
            return maxItem;
        }

        public static void Main(String[] args)
        {
            BaitapMang btm = new BaitapMang();
            int[] a = new int[50];
            btm.nhapmang(ref a);
            btm.xuatmang(a);
            Console.WriteLine("\n------------");
            int solan = 0;
            int mo = btm.getItemMaxOccurs(a,ref solan);
            Console.WriteLine("{0} xuat hien nhieu nhat vói {1} lan"
                ,mo,solan);
            Console.ReadKey();
        }
    }

}