using System;

namespace Session02
{
    public class PhuongtrinhB2
    {
        public void giai_bienluab_ptb2(int a, int b, int c)
        {
            if (a == 0)
                if (b == 0)
                    if (c == 0)
                        Console.WriteLine("phuong trinh co vo so nghiem");
                    else
                        Console.WriteLine("phuong trinh vo ly");
                else if (c == 0)//bx=0
                    Console.WriteLine("phuong trinh co nghiem x=0");
                else //bx+c=0
                    Console.WriteLine("phuong trinh bac 1 co nghiem {0}", -c / b);
            else if (b == 0)
                if (c == 0)//ax^2=0
                    Console.WriteLine("phuong trinh {0}x^2=0 co nghiem x=0", a);
                else
                {//ax^2+c=0
                    if (a * c < 0)
                        Console.WriteLine("phuong trinh {0}x^2+{1}=0 co nghiem x=+-{2}"
                            , a, c, Math.Sqrt(-c / a));
                    else
                        Console.WriteLine("phuong trinh {0}x^2+{1}=0 vo nghiem vi can bac 2 cua 1 so la khong am", a, c);
                }
            else if (c == 0)//ax^2+bx=0
                Console.WriteLine("phuong trinh {0}x^2+{1}x=0 co nghiem x1=0 va x2={2}", a, b, (float)-b / a);
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta == 0)
                    Console.WriteLine("phuong trinh co nghiem kep x={0}", -b / 2 * a);
                else if (delta < 0)
                    Console.WriteLine("phuong trinh vo nghiem (co nghiem phuc) vì can delta<0");
                else
                {
                    double x1 = (-b - Math.Sqrt(delta)) / 2 * a;
                    double x2 = (-b + Math.Sqrt(delta)) / 2 * a;
                    Console.WriteLine("phuong trinh co 2 nghiem phan biet x1={0} va x2={1}", x1, x2);
                }
            }
        }
        public static void Main(String[] args)
        {
            Console.Write("Nhap he so a: "); int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap he so b: "); int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap he so c: "); int c = Convert.ToInt32(Console.ReadLine());

            new PhuongtrinhB2().giai_bienluab_ptb2(a, b, c);
            Console.ReadKey();
        }
    }
}
