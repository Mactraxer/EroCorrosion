using System;
using UnityEngine;

public class DigTrigger : MonoBehaviour
{
    public Action<Block> LoseBlock;
    public Block TriggeredBlock => _triggerdBlock;

    private Block _triggerdBlock;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.TryGetComponent(out _triggerdBlock);
        print(_triggerdBlock);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out _triggerdBlock))
        {
            LoseBlock?.Invoke(_triggerdBlock);
        }
        
        _triggerdBlock = null;
    }
}