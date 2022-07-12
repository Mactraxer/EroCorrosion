using System;
using UnityEngine;

public class Block : MonoBehaviour
{
    public Action<Block> OnBlockBroken;

    [SerializeField] private BlockModel _model;
    [SerializeField] private SpriteRenderer _render;

    private int _currentHelthPoints;

    private void Start()
    {
        _render = GetComponent<SpriteRenderer>();

        _currentHelthPoints = _model.HealthPoints;
    }
    public void ApplyDamage(int damage)
    {
        if (_currentHelthPoints - damage < 1)
        {
            OnBlockBroken?.Invoke(this);
        }
        else
        {
            _currentHelthPoints -= damage;
        }
    }
}