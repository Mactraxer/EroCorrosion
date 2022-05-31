using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CellContent : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private TextMeshProUGUI _nameText;
    [SerializeField] private TextMeshProUGUI _priceText;

    public void UpdateCell(string name, string imagePath, int price)
    {
        _nameText.text = name;
        _priceText.text = price.ToString();
        _image.sprite = Resources.Load<Sprite>(imagePath);
    }
}
