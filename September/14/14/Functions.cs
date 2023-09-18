namespace BankAccountOperation
{
    public class Actions
    {
        public static double IncreaseBalance(double amount, double Balance)
        {
            Balance += amount;
            return Balance;
        }

        public static double DecreaseBalance(double amount, double Balance)
        {
            if (amount > Balance)
                throw new Exception("Not enough funds");

            Balance -= amount;
            return Balance;
        }
    }
}