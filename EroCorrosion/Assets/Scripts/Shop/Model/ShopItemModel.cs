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
