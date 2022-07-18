using System.Collections.Generic;

public interface ICustomer
{
    public List<ResourceModel> GetResource();
    public void ApplyPayment(int sum);
}