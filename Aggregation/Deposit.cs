namespace Aggregation
{
    public abstract class Deposit
    {
        public readonly decimal Amount { get; }
        public readonly int Period { get; }

        public Deposit(decimal Amount, int Period) 
        {
            decimal depositAmount = Amount;
            int depositPeriod = Period;
        }
        public abstract decimal Income();
    }
}
