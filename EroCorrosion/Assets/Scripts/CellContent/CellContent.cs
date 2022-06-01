using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class CellContent : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private TextMeshProUGUI _nameText;
    [SerializeField] private TextMeshProUGUI _priceText;
    [SerializeField] private Button _button;

    public event Action<string> TapOnButton;

    private void Awake()
    {
        _button.onClick.AddListener(TapButtonHandler);    
    }

    private void TapButtonHandler()
    {
        TapOnButton?.Invoke(_nameText.text);
    }

    public void UpdateCell(string name, string imagePath, int price)
    {
        _nameText.text = name;
        _priceText.text = price.ToString();
        _image.sprite = Resources.Load<Sprite>(imagePath);
    }
}
