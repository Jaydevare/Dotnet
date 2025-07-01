namespace ATM;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to 69 ATM service");
        try
        {
            Console.WriteLine("Please Enter Your Details for Transaction");
            Transaction tx = new Transaction();
            Console.WriteLine("Please Enter Your 5 Digit Card Number");
            tx.cradNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Amout to Withdraw");
            tx.withdrwalAmt = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter your 4 Digit ATM Pin");
            tx.atmPin = int.Parse(Console.ReadLine());
            Console.WriteLine("Do you Want SMS for Your Transaction");
            Console.WriteLine("1 yes");
            Console.WriteLine("2 No");
            int a = int.Parse(Console.ReadLine());
            if(a == 1)
            {
                Console.WriteLine("Enter Your Mobile No");
                tx.mobileNo = double.Parse(Console.ReadLine());
                tx.onSMS += sms;
            }
            else
            {
                tx.mobileNo = 0;
            }
            Console.WriteLine("Do You Want To Print Slip");
            Console.WriteLine("1 yes");
            Console.WriteLine("2 No");
            int b = int.Parse(Console.ReadLine());
            if (b == 1)
            {
                tx.onTSlip += printSlip;
            }
            Console.WriteLine(tx.withdrwal(tx.withdrwalAmt));
            Console.WriteLine("Amout Availabe is " + tx.amtFixed);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    private static void sms(String value)
    {
        Console.WriteLine($"SMS has been sent to Mobile No {value} ");
    }

    private static void printSlip(String value)
    {
        Console.WriteLine($"{value}");
    }
}
