namespace Aggregation
{
    public class SpecialDeposit : Deposit
    {
        public new readonly decimal Amount { get; }
        public new readonly int Period { get; }
        
        public SpecialDeposit(decimal amount, int period) : base(amount, period)
        {
            Amount = amount;
            Period = period;
        }

        public override decimal Income()
        {
            decimal totalIncome = 0;
            decimal newAmount = Amount;
            for (int i = 0; i <= Period; i++)
            {
                totalIncome += newAmount * ((decimal)i / 100);
                newAmount = newAmount * (1 + (decimal)i / 100);
            }
            return totalIncome;
        }
    }
}
