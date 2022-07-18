public class Wallet
{
    private int _count;
    private WalletUI _view;

    public Wallet(WalletUI view)
    {
        _view = view;
    }

    public int Count => _count;

    public void Add(int value)
    {
        _count += value;
        _view.UpdateView(_count);
    }
}