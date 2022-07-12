using UnityEngine;

public class Digger : MonoBehaviour
{
    [SerializeField] private DigTrigger _trigger;
    [SerializeField] private DigTool _tool;

    public void Dig()
    {
        Block block = _trigger.TriggeredBlock;
        if (block == null) return;

        int damage = _tool.Damage;
        block.ApplyDamage(damage);
    }
}