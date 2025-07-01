namespace ATM;
public delegate void AtmBasket(String name);
internal class Transaction
{
    public event AtmBasket onSMS;
    public event AtmBasket onTSlip;
    public float amtFixed = 500000;
    public int cradNo { get; set; }
    public float withdrwalAmt { get; set; }
    public int atmPin { get; set; }
    public double mobileNo { get; set; }

    public String withdrwal(float amt)
    {
        if (amt > amtFixed)
        {
            return "Insufficent Balance";
        }
        else
        {
            if(mobileNo>0 && onSMS != null)
            {
                onSMS($"{mobileNo}");
            }
            if(onTSlip != null)
            {
                onTSlip("Transaction Done Succesfully");
            }
            amtFixed = amtFixed - amt;
            return "Withdrwal is Successfull of" + amt;
        }
    }
}       
