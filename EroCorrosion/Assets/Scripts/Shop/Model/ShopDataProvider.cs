using System.Collections.Generic;

public class ShopItemModel
{
    public enum ShopItemType
    {
        warriorEgg, metalCorrosionEgg, leathCorrosionEgg, clothCorrosionEgg, mineralCorrosionEgg, woodCorrosionEgg
    }

    public string _name { get; private set; }
    public int _price { get; private set; }
    public string _imagePath { get; private set; }
    public ShopItemType _type { get; private set; }

    public ShopItemModel(string name, int price, string imagePath, ShopItemType type)
    {
        _name = name;
        _price = price;
        _imagePath = imagePath;
        _type = type;
    }

}

public interface IShopDataProvider 
{
    public ShopItemModel[] GetFiltredModels(ShopContentFilter filter);
}


public class ShopDataProvider: IShopDataProvider
{

    private List<ShopItemModel> models;

    public ShopDataProvider()
    {
        InitTestModels();
    }

    private void InitTestModels()
    {
        models = new List<ShopItemModel>();
        models.Add(new ShopItemModel("Egg", 1, "Sprites/Egg1", ShopItemModel.ShopItemType.warriorEgg));
        models.Add(new ShopItemModel("Egg1", 2, "Sprites/Egg2", ShopItemModel.ShopItemType.metalCorrosionEgg));
        models.Add(new ShopItemModel("Egg2", 3, "Sprites/Egg3", ShopItemModel.ShopItemType.leathCorrosionEgg));
        models.Add(new ShopItemModel("Egg3", 4, "Sprites/Egg4", ShopItemModel.ShopItemType.clothCorrosionEgg));
        models.Add(new ShopItemModel("Egg4", 5, "Sprites/Egg1", ShopItemModel.ShopItemType.mineralCorrosionEgg));
        models.Add(new ShopItemModel("Egg4", 5, "Sprites/Egg2", ShopItemModel.ShopItemType.woodCorrosionEgg));          
    }

    ShopItemModel[] IShopDataProvider.GetFiltredModels(ShopContentFilter filter)
    {
        ShopItemModel[] filtredModels = models.FindAll((item) => FilterTypeCompare(filter, item._type)).ToArray();
        return filtredModels;
    }

    private bool FilterTypeCompare(ShopContentFilter shopFilter, ShopItemModel.ShopItemType itemType)
    {
        bool result = false;
        switch (shopFilter, itemType)
        {
            case (ShopContentFilter.warrior, ShopItemModel.ShopItemType.warriorEgg):
                result = true;
                break;
            case (ShopContentFilter.metal, ShopItemModel.ShopItemType.metalCorrosionEgg):
                result = true;
                break;
            case (ShopContentFilter.leather, ShopItemModel.ShopItemType.leathCorrosionEgg):
                result = true;
                break;
            case (ShopContentFilter.cloth, ShopItemModel.ShopItemType.clothCorrosionEgg):
                result = true;
                break;
            case (ShopContentFilter.mineral, ShopItemModel.ShopItemType.mineralCorrosionEgg):
                result = true;
                break;
            case (ShopContentFilter.wood, ShopItemModel.ShopItemType.woodCorrosionEgg):
                result = true;
                break;
            default:
                break;
        }

        return result;
    }
}
