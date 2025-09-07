//2. Encapsulation

// Wrapping data (fields) and methods together, and controlling access using access modifiers.
// public → Accessible everywhere
// private → Accessible only inside the class
// protected → Accessible in class + derived classes
// internal → Accessible within the same assembly

class BankAccount
{
    private double balance; // private field

    public void Deposit(double amount)
    {
        balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount <= balance)
            balance -= amount;
        else
            Console.WriteLine("Insufficient balance!");
    }

    public void ShowBalance()
    {
        Console.WriteLine($"Balance: {balance}");
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount();
        account.Deposit(1000);
        account.Withdraw(500);
        account.ShowBalance();  // Balance: 500
    }
}