namespace Aggregation
{
    public abstract class Deposit
    {
        public readonly decimal Amount;
        public readonly int Period;

        public Deposit(decimal Amount, int Period)
        {
            decimal depositAmount = Amount;
            int depositPeriod = Period;            
        }
        public abstract decimal Income();
    }
}