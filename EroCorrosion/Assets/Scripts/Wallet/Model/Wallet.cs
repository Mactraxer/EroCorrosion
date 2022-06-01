public class Wallet
{
    public int _money { get; private set; }

    public Wallet(int money)
    {
        if (money < 0) { throw new System.ArgumentException("Wallet can't initialize with negative count money"); }
        _money = money;
    }

    public bool CanDoTransaction(int value)
    {
        if (value > _money)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public void DoTransaction(int value)
    {
        if (CanDoTransaction(value) == false) { throw new System.ArgumentException("Have not money in wallet for do transaction");  }
        _money -= value;
    }
}
