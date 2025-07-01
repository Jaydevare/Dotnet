namespace Person;

internal class Shipper : Person
{
    public int ShiperID { get; set; }
    public String ModeOfShipping { get; set; }

    public Shipper()
    {
        Console.WriteLine("In const Of Shipping");
    }
}
