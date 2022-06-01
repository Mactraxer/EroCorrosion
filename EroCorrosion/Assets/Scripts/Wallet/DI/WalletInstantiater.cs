using UnityEngine;

public class WalletInstantiater : MonoBehaviour
{
    [SerializeField] private WalletView _walletPrefab;
    [SerializeField] private Canvas _canvas;

    private WalletPresenter _walletPresenter;

    public IWallet Wallet => _walletPresenter;

    public void InitializeWallet()
    {
        _walletPresenter = new WalletPresenter();
        IWalletPresenter presenter = _walletPresenter;
        IWalletView view = Instantiate(_walletPrefab, _canvas.transform);
        presenter.Initialize(view);
    }

}
