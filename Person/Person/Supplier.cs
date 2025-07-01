namespace Person;

internal class Supplier : Person
{
    public int SupplierID { get; set; }
    public string SupplierOf { get; set; }

    public Supplier()
    {
        Console.WriteLine("In Const of Supplier");
    }
}
