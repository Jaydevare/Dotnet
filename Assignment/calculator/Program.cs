using System.Transactions;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, z;
            int ch = 0;
            do
            {
                Console.WriteLine("Enter your Choice");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subrtaction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exit");

                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter Num1 =>");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Num2 =>");
                        b = int.Parse(Console.ReadLine());
                        z = a + b;
                        Console.WriteLine(z);
                        break;
                    case 2:
                        Console.WriteLine("Enter Num1 =>");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Num2 =>");
                        b = int.Parse(Console.ReadLine());
                        z = a - b;
                        Console.WriteLine(z);
                        break;
                    case 3:
                        Console.WriteLine("Enter Num1 =>");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Num2 =>");
                        b = int.Parse(Console.ReadLine());
                        z = a * b;
                        Console.WriteLine(z);
                        break;
                    case 4:
                        Console.WriteLine("Enter Num1 =>");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Num2 =>");
                        b = int.Parse(Console.ReadLine());
                        z = a / b;
                        Console.WriteLine(z);
                        break;
                    default :
                        Console.WriteLine("Wrong Choice");
                        break;
                } 
            } while (ch!=5);
        }
    }
}
