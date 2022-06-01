using UnityEngine;
using UnityEngine.UI;
using System;

public class ShopView : MonoBehaviour, IShopView
{
    // UI components
    [SerializeField] private Button _warriorsTabButton;
    [SerializeField] private Button _metalCorrosionTabButton;
    [SerializeField] private Button _leatherCorrosionTabButton;
    [SerializeField] private Button _clothCorrosionTabButton;
    [SerializeField] private Button _mineralCorrosionTabButton;
    [SerializeField] private Button _woodCorrosionTabButton;
    [SerializeField] private Transform _contentTransform;
    [SerializeField] private CellContent _cellPrefab;

    private void Awake()
    {
        _warriorsTabButton.onClick.AddListener(TapWarriorTabHandler);
        _metalCorrosionTabButton.onClick.AddListener(TapMetalCorrosionTabHandler);
        _leatherCorrosionTabButton.onClick.AddListener(TapLeatherCorrosionTabHandler);
        _clothCorrosionTabButton.onClick.AddListener(TapClothCorrosionTabHandler);
        _mineralCorrosionTabButton.onClick.AddListener(TapMineralCorrosionTabHandler);
        _woodCorrosionTabButton.onClick.AddListener(TapWoodCorrosionTabHandler);
    }

    // IShopView interface
    public event Action<ShopContentFilter> TapTab;
    public event Action<string> TapOnCellButton;

    public void PrintError(string message)
    {
        print(message);
    }

    public void UpdateView(ShopItemModel[] models)
    {
        _contentTransform.DetachChildren();

        for(int i = 0; i< models.Length; i++)
        {
            CellContent instantiatedContent = Instantiate(_cellPrefab, _contentTransform);
            instantiatedContent.TapOnButton += TapOnCellButton;
            instantiatedContent.UpdateCell(models[i]._name, models[i]._imagePath, models[i]._price);
        }
    }

    // Event handlers
    private void TapWarriorTabHandler()
    {
        TapTab?.Invoke(ShopContentFilter.warrior);
    }

    private void TapMetalCorrosionTabHandler()
    {
        TapTab?.Invoke(ShopContentFilter.metal);
    }

    private void TapLeatherCorrosionTabHandler()
    {
        TapTab?.Invoke(ShopContentFilter.leather);
    }

    private void TapClothCorrosionTabHandler()
    {
        TapTab?.Invoke(ShopContentFilter.cloth);
    }

    private void TapMineralCorrosionTabHandler()
    {
        TapTab?.Invoke(ShopContentFilter.mineral);
    }

    private void TapWoodCorrosionTabHandler()
    {
        TapTab?.Invoke(ShopContentFilter.wood);
    }
        
}
