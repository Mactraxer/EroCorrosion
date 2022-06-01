using System;

public interface IShopView
{
    public event Action<ShopContentFilter> TapTab;
    public event Action<string> TapOnCellButton;
    public void UpdateView(ShopItemModel[] models);
}
