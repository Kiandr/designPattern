namespace CreationalDesignPattern
{
    public interface IFactory
    {
        CreditCard InitFactory(int score);
        CreditCard InitFactory(ScoreClass scoreClass);
    }
}