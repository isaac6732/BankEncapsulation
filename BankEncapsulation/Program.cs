namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount();

            bankAccount.Deposit(5000.00);
            bankAccount.GetBalance();

            bankAccount.Whithdraw(1.30);
            Console.WriteLine("New Balance:");
            bankAccount.GetBalance();

        }
    }
}
