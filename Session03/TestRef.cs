using System;

namespace Session03
{
    class TestRef
    {
        void abc()
        {
            Session04.dataaccess.DataAccess d = new Session04.dataaccess.DataAccess();
            Session04.businesslogic.BL b = new Session04.businesslogic.BL();
           // b.abc();
        }
    }
}
