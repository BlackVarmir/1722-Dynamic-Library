namespace _1722
{
    public class Account
    {
        public int Id { get; private set; }
        public int CurrencyId { get; set; }
        public int AccountTypeId { get; set; }
        public int FundsTypeId { get; set; }
        public int InstitutionId { get; set; }
        public decimal Balance { get; private set; }
        public string Note
        {
            get; set;
        }

        private static int nextId = 1;

        public Account()
        {
            Id = nextId++;
        }

        public void IncreaseBalance(decimal amount)
        {
            Balance += amount;
        }

        public void DecreaseBalance(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
            }
            else
            {
                throw new InvalidOperationException("Insufficient funds.");
            }
        }
    }
}