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

        block.ApplyDamage(damage);
        OnDigBlock?.Invoke(blockCount, block.Price);
    }
}