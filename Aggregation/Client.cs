namespace Aggregation
{
    public class Client
    {
        private Deposit[] deposits;
        public Client()
        {
            deposits = new Deposit[10];
        }

        public bool AddDeposit(Deposit deposit)
        {
            for(int i = 0; i < deposits.Length; i++)
            {
                if (deposits[i] == null)
                {
                    deposits[i] = deposit;
                    return true;
                }
            }
            return false;
        }

        public decimal TotalIncome()
        {
            decimal totalIncome = 0;
            
                for (int i = 0; i < deposits.Length; i++)
                {
                if (deposits[i] != null) totalIncome += deposits[i].Income();
                }
                return totalIncome;
           
        }

        public decimal MaxIncome()
        {
            decimal maxIncome = deposits[0].Income();
            for (int i = 0; i < deposits.Length; i++)
            {
                if (deposits[i]!= null){
                    if (deposits[i].Income() > maxIncome) maxIncome = deposits[i].Income();
                }               
            }
            return maxIncome;
        }
        public decimal GetIncomeByNumber(int number)
        {
            decimal valueOfIncome = 0;
            if (deposits[number - 1] != null) valueOfIncome = deposits[number - 1].Income();
            return valueOfIncome;
        }
    }
}