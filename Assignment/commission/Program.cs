namespace commission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Salary of Salesman");
            float sal = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Total sales");
            int salesamt  = int.Parse(Console.ReadLine());

            if ((salesamt >= 5000) && (salesamt <= 7500))
            {
                sal = sal + (float)(sal * 0.03);
                Console.WriteLine(sal);
            }
            else if ((salesamt >= 7501) && (salesamt <= 10500))
            {
                sal = sal + (float)(sal * 0.08);
                Console.WriteLine(sal);
            }
            else if ((salesamt >= 10501) && (salesamt <= 15000))
            {
                sal = sal + (float)(sal * 0.11);
                Console.WriteLine(sal);
            }
            else if (salesamt >= 15001)
            {
                sal = sal + (float)(sal * 0.15);
                Console.WriteLine(sal);
            }
            else
            {
                Console.WriteLine(sal);
            }
        }
    }
}
