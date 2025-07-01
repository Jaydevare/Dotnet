namespace LeapYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter year to check year is leap year or not");
            int year = int.Parse(Console.ReadLine());
            if (year % 4 == 0 || year % 400 == 0)
            {
                Console.WriteLine("Year is Leap Year");
            }
            else
            {
                Console.WriteLine("Year is not a leap year");
            }
        }
    }
}
