namespace Aggregation
{
    public class LongDeposit : Deposit
    {
        public new decimal Amount { get; }
        public new int Period { get; }
        public LongDeposit(decimal amount, int period) : base(amount, period)
        {
            Amount = amount;
            Period = period;
        }

        public override decimal Income()
        {
            decimal percent = 15;
            decimal totalIncome = 0;
            decimal newAmount = Amount;
            for (int i = 1; i <= Period; i++)
            {
                if (i >= 7)
                {
                    totalIncome += newAmount * (percent / 100);
                    newAmount = newAmount * (1 + percent / 100);
                }                
            }
            return totalIncome;
        }
    }
}
