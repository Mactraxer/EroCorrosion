using System.Collections.Generic;

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

    ShopItemModel IShopDataProvider.GetModelBy(string name)
    {
        ShopItemModel model = models.Find((item) => item._name == name);
        if (model == null)
        {
            throw new System.ArgumentException($"Not found ShopItemModel with name = '{name}'");
        }

        return model;
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
