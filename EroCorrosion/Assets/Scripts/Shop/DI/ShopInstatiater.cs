using UnityEngine;

public class ShopInstatiater : MonoBehaviour
{
    [SerializeField] ShopView _viewPrefab;
    [SerializeField] Canvas _canvas;

    private void Awake()
    {
        IShopPresenter presenter = new ShopPresenter();
        IShopView view = Instantiate(_viewPrefab, _canvas.transform);
        IShopDataProvider dataProvider = new ShopDataProvider();

        presenter.Initialize(view, dataProvider);
    }

}
