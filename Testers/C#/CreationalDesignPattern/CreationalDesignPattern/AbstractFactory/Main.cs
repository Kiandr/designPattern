using System;
namespace CreationalDesignPattern.AbstractFactory
{


    public interface IValidator
    {
        Boolean IsValid(CreditCard creditCard);
    }

    public class AmexFactory { public AmexFactory() { } }
    public class VisaFactory { public VisaFactory() { } }

    public class CreaditCardFactory
    {
        public CreaditCardFactory()
        {
        }
        public static CreaditCardFactory GetFactory(int score)
        {
            if (score > 650) { return new AmexFactory(); }
            return new VisaFactory();
        }

        public abstract getCreditCard(CreaditCardType cardType);
        public abstract validateCreditCard(CreaditCardType cardType);
    }
}

public class Main
    {
        public class CreaditCard { 
        
        }
        public Main()
        {

        }
    }
}
