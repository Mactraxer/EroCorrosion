using UnityEngine;
using TMPro;

public class WalletUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _walletText;

    public void UpdateView(int sum)
    {
        _walletText.text = $"{sum}";
    }
}