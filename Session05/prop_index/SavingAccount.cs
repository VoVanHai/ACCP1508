using System;

namespace Session05.prop_index
{
    class SavingAccount : Account
    {
        public override int SomeType
        {
            get
            {
                return 100;
            }
        }

        public static void Main(String[] args)
        {
            Account.MyProp = 10;
            Account acc = new SavingAccount();
            acc.AccountNumber = "SV100";
            //acc.Balance = 10000d;//lỗi - read only
            double t = acc.Balance;
            acc.Owner = "Than thi det";
            //string n = acc.Owner;//lỗi - write only
        }
    }
}
