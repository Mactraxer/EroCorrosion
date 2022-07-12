using UnityEngine;

public class DigTrigger : MonoBehaviour
{
    public Block TriggeredBlock => _triggerdBlock;

    private Block _triggerdBlock;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("OnCollisitionEnter");
        collision.gameObject.TryGetComponent(out _triggerdBlock);
        print(_triggerdBlock);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        print("OnCollisitionExit");
        _triggerdBlock = null;
    }
}