using UnityEngine;

public class GameInstantiater : MonoBehaviour
{

    [SerializeField] private WalletInstantiater _walletInstantiater;
    [SerializeField] private ShopInstantiater _shopInstantiater;

    private void Awake()
    {
        _walletInstantiater.InitializeWallet();
        _shopInstantiater.InitializeShop((_walletInstantiater.Wallet));
    }

}
