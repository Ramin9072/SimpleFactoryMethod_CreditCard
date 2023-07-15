using FactoryMethod;
using System.ComponentModel.DataAnnotations;
using System.Net.WebSockets;

internal class Program
{
    private static void Main(string[] args)
    {

        ICreditCard cardDetails = CreditCardFactory.GetCreditCard("Platnium");

        if (cardDetails is not null)
        {
            Console.WriteLine("CardType: " + cardDetails.GetCardType());
            Console.WriteLine("CreditLimit: " + cardDetails.GetCreditLimit());
            Console.WriteLine("AnnualCharge: " + cardDetails.GetAnnualCharge());
        }
        else
        {
            Console.WriteLine("Invalid credit card type");
        }

        Console.ReadLine();
    }
}