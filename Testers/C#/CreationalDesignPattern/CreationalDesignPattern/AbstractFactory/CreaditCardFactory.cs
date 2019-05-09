using System;
namespace CreationalDesignPattern.AbstractFactory
{
    public class CreaditCardFactory
    {   
        public CreaditCardFactory()
        {
        }
        public static CreaditCardFactory GetFactory(int score) { 
            if (score > 650) { return new AmexFactor(); }
            return VisaFactory();
        }

        public abstract getCreditCard(CreaditCardType cardType);
        public abstract validateCreditCard(CreaditCardType cardType);
    }
}
