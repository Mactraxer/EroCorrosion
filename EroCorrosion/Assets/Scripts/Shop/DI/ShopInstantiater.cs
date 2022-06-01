using UnityEngine;

public class ShopInstantiater : MonoBehaviour
{
    [SerializeField] ShopView _viewPrefab;
    [SerializeField] Canvas _canvas;

    public void InitializeShop(IWallet wallet)
    {
        IShopPresenter presenter = new ShopPresenter();
        IShopView view = Instantiate(_viewPrefab, _canvas.transform);
        IShopDataProvider dataProvider = new ShopDataProvider();

        presenter.Initialize(view, dataProvider, wallet);
    }

}
