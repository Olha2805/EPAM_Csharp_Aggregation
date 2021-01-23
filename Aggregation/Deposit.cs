namespace Aggregation
{
    public abstract class Deposit
    {
        public decimal Amount { get; }
        public int Period { get; }

        public Deposit(decimal Amount, int Period) 
        {
            decimal depositAmount = Amount;
            int depositPeriod = Period;
        }
        public abstract decimal Income();
    }
}
