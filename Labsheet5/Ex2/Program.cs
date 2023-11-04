namespace Ex2;

class Program
{
    static void Main(string[] args)
    {
        BankAccount B1 = new BankAccount("B123", 5000);

        BankAccount B2 = new BankAccount("B456",5000);

        B1.PrintDetails();

        B2.PrintDetails();

        B1.Deposit(10000);
        B2.Deposit(5000);       

        B1.PrintDetails();
        B2.PrintDetails();

        B1.Withdraw(2000);
        B2.Withdraw(500);

        B1.PrintDetails();
        B2.PrintDetails();

        Console.ReadLine();
    }
}

