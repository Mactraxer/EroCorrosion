using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, ICustomer
{
    [SerializeField] private Mover _mover;
    [SerializeField] private Digger _digger;
    [SerializeField] private DigTool _tool;
    [Header("Wallet")]
    [SerializeField] private WalletUI _walletView;
    private Wallet _wallet;
    [Header("Bag")]
    private Bag _bag;
    [SerializeField] private BagModel _bagModel;
    [SerializeField] private BagUI _bagView;

    private void Start()
    {
        _digger.OnDigBlock += OnDigBlockHandler;

        _bag = new Bag(_bagModel, _bagView);
        _wallet = new Wallet(_walletView);
    }

    private void OnDisable()
    {
        _digger.OnDigBlock -= OnDigBlockHandler;
    }

    private void OnDigBlockHandler(int blockCount, ResourceModel resource)
    {
        print("Digged block");
        _bag.TryAddResouces(blockCount, resource);
    }

    public void Dig()
    {
        _digger.Dig(_tool.Damage);
    }

    public void Jump()
    {
        _mover.Jump();
    }

    public void Move(float value)
    {
        _mover.Move(value);
    }

    public void ApplyBlockReward(int reward, ResourceModel resource)
    {
        print("Destroy block");
        _bag.TryAddResouces(reward, resource);
    }

    List<ResourceModel> ICustomer.GetResource()
    {
        return _bag.UploadResources();
    }

    void ICustomer.ApplyPayment(int sum)
    {
        _wallet.Add(sum);
    }
}