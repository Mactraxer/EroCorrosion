using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Action<Enemy> OnDie;

    [SerializeField] private int _healthPoint;

    public void ApplyDamage(int damage)
    {
        if (_healthPoint - damage < 1)
        {
            OnDie?.Invoke(this);
        }
        else
        {
            _healthPoint -= damage;
        }

        print(_healthPoint);
    }
}