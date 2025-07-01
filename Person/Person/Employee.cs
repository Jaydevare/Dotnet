namespace Person;

internal class Employee : Person
{
    public int EmpId { get; set; }
    public String Department { get; set; }

    public Employee()
    {
        Console.WriteLine("In const of Employee");
    }
}
