using System;
namespace CreationalDesignPattern
{
    public class Factory : IFactory
    {
        public CreditCard InitFactory(int score) {
            if (score < 650)
                return new CreditCard(ScoreClass.Gold);
            if (score <= 650 && score > 500)
                return new CreditCard(ScoreClass.Silver);
            else
                return new CreditCard(ScoreClass.Bronze);
        }

        public CreditCard InitFactory(ScoreClass scoreClass)
        {
            switch (scoreClass)
            {
                case ScoreClass.Gold:
                {
                    return new CreditCard(scoreClass);
                }
                case ScoreClass.Silver:
                {
                    return new CreditCard(scoreClass);
                }
                case ScoreClass.Bronze:
                {
                    return new CreditCard(scoreClass);
                }
                default:
                    return new CreditCard(scoreClass);
            }
        }
    }
}
