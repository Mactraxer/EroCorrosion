
public interface IShopPresenter
{
    public void Initialize(IShopView view, IShopDataProvider dataProvider);
    public void Deinitialize();
}
