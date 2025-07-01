namespace Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salary = float.Parse(Console.ReadLine());
            Console.WriteLine("Salaryu is " + salary);
            float HRA = (float)(salary * 0.20);
            float DA = (float)(salary * 0.40);
            float PF = (float)(salary * 0.10);
            Console.WriteLine("HRA "+ HRA);
            Console.WriteLine("DA "+ DA);
            Console.WriteLine("PF "+ PF);
            float Gsal = salary + HRA + DA;
            Console.WriteLine(Gsal);
            float Nsa = Gsal - PF;
            Console.WriteLine(Nsa);


        }
    }
}
