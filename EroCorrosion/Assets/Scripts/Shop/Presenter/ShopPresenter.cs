public enum ShopContentFilter {
    warrior, metal, leather, cloth, mineral, wood
}

public class ShopPresenter: IShopPresenter
{

    private IShopDataProvider _dataProvider;
    private IShopView _view;
    private IWallet _wallet;

    public void Deinitialize()
    {
        _view.TapTab -= FilterContent;
    }

    public void Initialize(IShopView view, IShopDataProvider dataProvider, IWallet wallet)
    {
        _view = view;
        _dataProvider = dataProvider;
        _wallet = wallet;

        _view.TapTab += FilterContent;
        _view.TapOnCellButton += TapCellButtonHandler;
    }

    private void FilterContent(ShopContentFilter filter)
    {
        var filteredModels = _dataProvider.GetFiltredModels(filter);
        ShowContent(filteredModels);
    }

    private void TapCellButtonHandler(string itemName)
    {
        
        ShopItemModel model = _dataProvider.GetModelBy(itemName);
        if (_wallet.CanDoTransaction(model._price) == false)
        {
            // Event for warning modal
        }

        _wallet.DoTransaction(model._price);
    }

    private void ShowContent(ShopItemModel[] models)
    {
        _view.UpdateView(models);
    }

}
