using UnityEngine;
using TMPro;

public class BagUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _capacityText;
    public void UpdateView(int currentCapacity, int maxCapacity)
    {
        _capacityText.text = $"{currentCapacity}/{maxCapacity}";
    }
}