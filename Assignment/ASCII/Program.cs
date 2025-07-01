using System.Text;

namespace ASCII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Character ");
            char ch = char.Parse(Console.ReadLine());
            Console.WriteLine((int)ch);
        }
    }
}
