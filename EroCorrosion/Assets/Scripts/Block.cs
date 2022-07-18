using System;
using UnityEngine;

public class Block : MonoBehaviour
{
    public Action<Block> OnBlockBroken;
    public Action<int, ResourceModel> OnBlockDig;

    [SerializeField] private BlockModel _model;
    [SerializeField] private SpriteRenderer _render;

    private int _currentQuantityPoints;
    private int _currentCount;

    public int Price => _model.Resource.Price;
    public int Reward => _model.RewardCount;
    public ResourceModel Resource => _model.Resource;

    private void Start()
    {
        _render = GetComponent<SpriteRenderer>();

        _currentQuantityPoints = _model.QuantityPoints;
        _currentCount = _model.Count;
    }
    public void ApplyDamage(int damage)
    {
        if (_currentQuantityPoints - damage < 1)
        {
            BrokeBlockPart(damage);
        }
        else
        {
            _currentQuantityPoints -= damage;
        }
    }

    private void BrokeBlockPart(int damage)
    {
        if (_currentCount > 1)
        {
            var brokenParts = 1;
            brokenParts += damage / _model.QuantityPoints;

            if (brokenParts >= _currentCount)
            {
                OnBlockBroken?.Invoke(this);
            }
            else
            {
                _currentQuantityPoints = _model.QuantityPoints;
                _currentCount--;
                OnBlockDig?.Invoke(brokenParts, _model.Resource);
            }
        }
        else
        {
            OnBlockBroken?.Invoke(this);
        }
    }
}