namespace Session05.prop_index
{
    public abstract class Account
    {
        private string accountNumber;//data
        public string AccountNumber//property
        {
            get
            {
                return accountNumber;
            }
            set
            {
                accountNumber = value;
            }
        }
        public double Balance { get; private set; }
        public string Owner { private get; set; }

        public abstract int SomeType
        {
            get;
        }

        public static int MyProp { get; set; }
    }

    
}
