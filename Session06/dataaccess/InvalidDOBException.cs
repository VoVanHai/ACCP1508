using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session06.dataaccess
{
    public class InvalidDOBException:Exception
    {
        private string msg;
        public InvalidDOBException() : base()
        {

        }
        public InvalidDOBException(string msg) : base(msg)
        {
            this.msg = msg;
        }

        public void log()
        {
            Console.WriteLine(this.Message);
        }
    }
}
