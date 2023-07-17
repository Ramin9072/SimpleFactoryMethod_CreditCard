namespace FactoryMethod
{
    public abstract class CreditCardFactory2
    {
        protected abstract ICreditCard MakeProduct(); // this is factory method

        public ICreditCard CreateProduct() // concrete class 
        {
            return this.MakeProduct();
        }

        public class MoneyBackFactory : CreditCardFactory2
        {
            protected override ICreditCard MakeProduct()
            {
                ICreditCard product = new MoneyBack();
                return product;
            }
        }

        public class TitaniumFactory : CreditCardFactory2
        {
            protected override ICreditCard MakeProduct()
            {
                ICreditCard product = new Titanium();
                return product;
            }
        }

        public class PlatniumFactory : CreditCardFactory2
        {
            protected override ICreditCard MakeProduct()
            {
                ICreditCard product = new Platnium();
                return product;
            }
        }
    }
}
