public class WalletPresenter: IWalletPresenter, IWallet
{
    private IWalletView _view;
    private Wallet _wallet;

    void IWalletPresenter.Deinitialize()
    {
        throw new System.NotImplementedException();
    }

    void IWalletPresenter.Initialize(IWalletView view)
    {
        _view = view;
        _wallet = new Wallet(100);
    }

    void IWallet.DoTransaction(int value)
    {
        _wallet.DoTransaction(value);
    }

    bool IWallet.CanDoTransaction(int value)
    {
        return _wallet.CanDoTransaction(value);
    }

    
}
