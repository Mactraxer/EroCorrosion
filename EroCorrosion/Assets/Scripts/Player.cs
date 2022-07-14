using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Mover _mover;
    [SerializeField] private Digger _digger;
    [SerializeField] private Bag _bag;
    [SerializeField] private Wallet _wallet;
    [SerializeField] private DigTool _tool;

    private void Start()
    {
        _digger.OnDigBlock += OnDigBlockHandler;
    }

    private void OnDisable()
    {
        _digger.OnDigBlock -= OnDigBlockHandler;
    }

    private void OnDigBlockHandler(int blockCount, ResourceModel resource)
    {
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
        
    }
}