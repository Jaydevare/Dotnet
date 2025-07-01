namespace EmpNoDept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee no or Department code");
            string ch = Console.ReadLine();
            if((ch == "10") || (ch == "M"))
            {
                Console.WriteLine("Department NO 10");
                Console.WriteLine("Department Name Purchase");
                Console.WriteLine("Designation code is M");
                Console.WriteLine("Designation is Manager");
            }
            else if ((ch == "20") || (ch == "S"))
            {
                Console.WriteLine("Department NO 20");
                Console.WriteLine("Department Name Sales");
                Console.WriteLine("Designation code is S");
                Console.WriteLine("Designation is Supervisor");
            }
            else if ((ch == "30") || (ch == "A"))
            {
                Console.WriteLine("Department NO 30");
                Console.WriteLine("Department Name Production");
                Console.WriteLine("Designation code is A");
                Console.WriteLine("Designation is Analyst");
            }
            else if ((ch == "40") || (ch == "s"))
            {
                Console.WriteLine("Department NO 40");
                Console.WriteLine("Department Name Marketing");
                Console.WriteLine("Designation code is s");
                Console.WriteLine("Designation is Sales Person");
            }
            else if ((ch == "50") || (ch == "a"))
            {
                Console.WriteLine("Department NO 50");
                Console.WriteLine("Department Name Accounts");
                Console.WriteLine("Designation code is a");
                Console.WriteLine("Designation is Accountant");
            }
        }
    }
}
