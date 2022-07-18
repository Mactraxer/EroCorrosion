using System;
using UnityEngine;

public class Digger : MonoBehaviour
{
    public Action<int, ResourceModel> OnDigBlock;

    [SerializeField] private DigTrigger _trigger;

    public void Dig(int damage)
    {
        Block block = _trigger.TriggeredBlock;
        if (block == null) return;
        block.OnBlockDig += OnDigBlockHandler;
        block.ApplyDamage(damage);
        block.OnBlockDig -= OnDigBlockHandler;
    }

    private void OnDigBlockHandler(int count, ResourceModel resource)
    {
        OnDigBlock?.Invoke(count, resource);
    }
}