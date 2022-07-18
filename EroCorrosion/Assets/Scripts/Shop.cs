using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] private ShopTrigger _trigger;

    private void Start()
    {
        _trigger.OnDetectCustomer += OnDetectCustomerHandler;
    }

    private void OnDetectCustomerHandler(ICustomer customer)
    {
        CalculateResources(customer);
    }

    private void CalculateResources(ICustomer customer)
    {
        var resources = customer.GetResource();
        print(resources.Count + " Sold resources");
        int priceSum = 0;

        foreach (var resource in resources)
        {
            priceSum += resource.Price;
        }

        customer.ApplyPayment(priceSum);
    }
}