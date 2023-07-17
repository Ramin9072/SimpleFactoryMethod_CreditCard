namespace FactoryMethod
{
    public interface ICreditCard
    {
        public string GetCardType();
        public long GetCreditLimit();
        public long GetAnnualCharge();
    }

    // open close 
    // این رو زیر سوال میبرد
    // برای این از CreditCardFactory2 رجوع کنید
    public static class CreditCardFactory
    {
        public static ICreditCard GetCreditCard(string cardType)
        {
            ICreditCard creditCardDetails = null;
            if (cardType == "")
            {
                creditCardDetails = new MoneyBack();
            }
            else if (cardType == "Titanium")
            {
                creditCardDetails = new Titanium();
            }
            else if (cardType == "Platnium")
            {
                creditCardDetails = new Platnium();
            }

            return creditCardDetails;
        }

    }

    public class MoneyBack : ICreditCard
    {
        public string GetCardType() => "MoneyBack";
        public long GetCreditLimit() => 20000;
        public long GetAnnualCharge() => 5000;
    }
    public class Titanium : ICreditCard
    {
        public string GetCardType() => "Titanium";
        public long GetCreditLimit() => 200000;
        public long GetAnnualCharge() => 50000;
    }
    public class Platnium : ICreditCard
    {
        public string GetCardType() => "Platnium";
        public long GetCreditLimit() => 100000;
        public long GetAnnualCharge() => 30000;
    }
}
