using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _jumpForce;
    [SerializeField] private float _speedMovement;

    public void Jump()
    {
        _rigidbody.AddForce(Vector2.up * _jumpForce);
    }

    public void Move(float value)
    {
        _rigidbody.AddForce(new Vector2(value, 0) * _speedMovement);
    }
}
