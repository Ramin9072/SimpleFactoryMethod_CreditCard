using FactoryMethod;
using System.ComponentModel.DataAnnotations;
using System.Net.WebSockets;
using static FactoryMethod.CreditCardFactory2;

internal class Program
{
    private static void Main(string[] args)
    {

        ICreditCard cardDetails = CreditCardFactory.GetCreditCard("Platnium");

        ICreditCard creditCard2 = new PlatniumFactory().CreateProduct();


        if (cardDetails is not null)
        {
            Console.WriteLine("CardType: " + cardDetails.GetCardType());
            Console.WriteLine("CreditLimit: " + cardDetails.GetCreditLimit());
            Console.WriteLine("AnnualCharge: " + cardDetails.GetAnnualCharge());

            Console.WriteLine("---------------------Open close priciple vvvvv----------------------------");
            Console.WriteLine("CardType2: " + creditCard2.GetCardType()) ;
            Console.WriteLine("CreditLimit: " + creditCard2.GetCreditLimit()) ;
            Console.WriteLine("AnnualCharge: " + creditCard2.GetAnnualCharge()) ;
        }
        else
        {
            Console.WriteLine("Invalid credit card type");
        }

        Console.ReadLine();
    }
}