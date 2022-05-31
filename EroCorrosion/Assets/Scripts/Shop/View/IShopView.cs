using System;

public interface IShopView
{
    public event Action<ShopContentFilter> TapTab;
    public void UpdateView(ShopItemModel[] models);
}
