using System;

namespace Session06.dataaccess
{
    [Serializable]
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
