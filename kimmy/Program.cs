// See https://aka.ms/new-console-template for more information
using kimmy;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("請輸入一個正整數：");
            string input = Console.ReadLine() ?? "";//左邊如果=null,右邊會直接給空的字串

            if (!double.TryParse(input, out double value))
            {
                Console.WriteLine("請輸入數字");
                continue;//直接回while(true)
            }
            if (value <= 0)
            {
                Console.WriteLine("請輸入一個大於零的數字!");
                continue;
            }

            Console.WriteLine($"你輸入的數字是{value}");
            break;
        }
    } 
}