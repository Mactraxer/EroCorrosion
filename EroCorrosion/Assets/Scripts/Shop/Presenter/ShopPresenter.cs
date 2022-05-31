using UnityEngine;

public enum ShopContentFilter {
    warrior, metal, leather, cloth, mineral, wood
}

public class ShopPresenter: IShopPresenter
{

    private IShopDataProvider _dataProvider;
    private IShopView _view;

    public void Deinitialize()
    {
        _view.TapTab -= FilterContent;
    }

    public void Initialize(IShopView view, IShopDataProvider dataProvider)
    {
        _view = view;
        _dataProvider = dataProvider;

        _view.TapTab += FilterContent;
    }

    private void FilterContent(ShopContentFilter filter)
    {
        var filteredModels = _dataProvider.GetFiltredModels(filter);
        ShowContent(filteredModels);
    }

    private void ShowContent(ShopItemModel[] models)
    {
        _view.UpdateView(models);
    }

}
