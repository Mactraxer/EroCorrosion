
public interface IShopPresenter
{
    public void Initialize(IShopView view, IShopDataProvider dataProvider, IWallet wallet);
    public void Deinitialize();
}
