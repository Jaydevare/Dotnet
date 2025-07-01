using System.Collections;

namespace StronglyTypedCollectionExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Why should you not use weakly typed collections! Because of Boxing and Unboxing Problem!");
            //ArrayList items=new ArrayList();
            //items.Add(100);
            //int firstItem = items[0];
            List<string> items= new List<string>();
            items.Add("First");
            items.Add("Second");
            items.Add("Third");
            //string firstItem = items[0];
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");
            Stack<string> books=new Stack<string>();
            books.Push("Book-1");
            books.Push("Book-2");
            books.Push("Book-3");

            Console.WriteLine(books.Peek());

            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
            Console.WriteLine("");
            Queue<int> tickets=new Queue<int>();
            tickets.Enqueue(1);
            tickets.Enqueue(2);
            tickets.Enqueue(3);
            tickets.Enqueue(4);
            Console.WriteLine(tickets.Peek());
            foreach (var ticketNo in tickets)
            {
                Console.WriteLine(ticketNo);
            }

            Console.WriteLine("");
            Dictionary<int, string> employees = new Dictionary<int, string>();
            employees.Add(1, "A");
            employees.Add(2, "B");
            employees.Add(3, "C");
            employees.Add(4, "D");

            foreach (var key in employees.Keys)
            {
                Console.WriteLine($"Employee Id {key} and name is {employees[key]}!");
            }
        }
    }
}
