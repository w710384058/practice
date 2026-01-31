// See https://aka.ms/new-console-template for more information
using kimmy;

delegate void Notify();

class Program
{
    static void SayHello()
    {
        Console.WriteLine("Hello World!");
    }
    static void Main()
    {
        Notify notify = SayHello;
        notify();
        Console.ReadLine();
    } 
}