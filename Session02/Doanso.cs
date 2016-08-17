using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02
{
    public class Doanso
    {
        public void gameEngine()
        {
            //máy tính nghĩ ra một số
            short comp = (short)(new Random().Next(100) + 1);
            int dem = 0;
            do
            {
                Console.Write("Ban doan so may ?<1-100>: ");
                short user = Convert.ToInt16(Console.ReadLine());
                dem++;
                if (comp == user)
                {
                    Console.WriteLine("Ban doan trung sau {0} lan.",dem);
                    break;
                }
                else if (comp > user)
                    Console.WriteLine("So ban doan nho hon so may nghi");
                else
                    Console.WriteLine("So ban doan lon hon so may nghi");
            } while (true);
        }
    }
}
