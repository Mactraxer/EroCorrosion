using UnityEngine;
using TMPro;

public class WalletView : MonoBehaviour, IWalletView
{
    [SerializeField] private TextMeshProUGUI _moneyText;

    public void UpdateWallet(string value)
    {
        _moneyText.text = value;
    }

}
