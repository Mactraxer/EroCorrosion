using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Mover _mover;
    [SerializeField] private Digger _digger;

    public void Dig()
    {
        _digger.Dig();
    }

    internal void Jump()
    {
        _mover.Jump();
    }

    internal void Move(float value)
    {
        _mover.Move(value);
    }
}