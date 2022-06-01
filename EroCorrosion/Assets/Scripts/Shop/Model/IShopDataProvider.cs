public interface IShopDataProvider
{
    public ShopItemModel[] GetFiltredModels(ShopContentFilter filter);
    public ShopItemModel GetModelBy(string name);
}