namespace swaping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int a = 16, b = 19;
            int temp;
            Console.WriteLine("num1 = " + a);
            Console.WriteLine("num2 = " + b);

            temp = a;
            a = b;
            b = temp;

            Console.WriteLine("num1 = " + a);
            Console.WriteLine("num2 = " + b);
        }
    }
}
