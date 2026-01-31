// See https://aka.ms/new-console-template for more information
using kimmy;

class Program
{
    static void Main()
    {
        BankAccount acc1 = new BankAccount(100);
        Console.WriteLine(acc1.Balance);
        BankAccount acc2 = new BankAccount(-50);
        Console.WriteLine(acc2.Balance);

        acc1.Balance = -999;
        Console.WriteLine(acc1.Balance);

        Console.ReadLine();
    } 
}