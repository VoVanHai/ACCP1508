using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session06.dataaccess
{
    public class Thisinh
    {
        private int ns;
        public string SoDB { get; set; }

        public int Namsinh
        {
            get
            {
                return ns;
            }
            set
            {
                int t = DateTime.Now.Year - value;
                if (t < 18 || t > 60)
                {
                    throw new InvalidDOBException("Invalid Birth year");
                    //throw new Exception("Invalid year");
                }
                ns = value;
            }
        }
    }
}
