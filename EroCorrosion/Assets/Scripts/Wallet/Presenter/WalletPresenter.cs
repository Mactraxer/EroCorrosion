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
        _view.UpdateWallet(_wallet._money.ToString());
    }

    void IWallet.DoTransaction(int value)
    {
        _wallet.DoTransaction(value);
        _view.UpdateWallet(_wallet._money.ToString());
    }

    bool IWallet.CanDoTransaction(int value)
    {
        return _wallet.CanDoTransaction(value);
    }

}
