namespace Person;

internal class Person
{
    public String Name { get; set; }
    public String City { get; set; }
    public String State { get; set; }
    public double PhoneNo { get; set; }

    public Person()
    {
        Console.WriteLine("In const Of Person");
    }
}
