using System;
using UnityEngine;

public class ShopTrigger : MonoBehaviour
{
    public Action<ICustomer> OnDetectCustomer;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out ICustomer cutomer))
        {
            OnDetectCustomer?.Invoke(cutomer);
        }
    }
}