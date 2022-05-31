public interface IWallet
{
    public bool CanDoTransaction(int value);
    public void DoTransaction(int value);
} 
