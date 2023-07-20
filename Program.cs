// See https://aka.ms/new-console-template for more informationpublic class SBI

    public class SBI
{
    public float rate_sbi = 6.5f;
    public double calc_Sbi(double amount, int years)
    {
        return amount = ((amount * rate_sbi * years) / 100 + (amount));
    }
}

public class HDFC : SBI
{
    public float rate_HDFC = 8.5f;
    public double calc_HDFC(double amount, int years)
    {
        return amount = ((amount * rate_HDFC * years) / 100 + (amount));
    }
}
public class PNB : HDFC
{
    public float rate_PNB = 5.0f;
    public double calc_PNB(double amount, int years)
    {
        return amount = ((amount * rate_PNB * years) / 100 + (amount));
    }
}
class abc
{
    static void Main(string[] args)
    {
        PNB f = new PNB();

        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter your address:");
        string address = Console.ReadLine();

        Console.WriteLine("Enter your mobile number:");
        string mobileNumber = Console.ReadLine();

        Console.WriteLine("Enter your amount:");
        double amount = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the number of years:");
        int years = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nCustomer Details:");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Address: " + address);
        Console.WriteLine("Mobile Number: " + mobileNumber);

        Console.WriteLine("\nInterest Calculations:");
        Console.WriteLine("Your amount according to SBI after " + years + " years will be " + f.calc_Sbi(amount, years));
        Console.WriteLine("Your amount according to HDFC after " + years + " years will be " + f.calc_HDFC(amount, years));
    }
}