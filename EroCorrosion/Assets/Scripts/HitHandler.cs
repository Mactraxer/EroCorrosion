using UnityEngine;

public class HitHandler : MonoBehaviour
{
    [SerializeField] private EnemyPool _pool;
    [SerializeField] private Bounds _hitBounds;

    private Camera _camera;
    private Enemy _enemy;

    private void Start()
    {
        _camera = Camera.main;
        _enemy = _pool.Next();
    }

    public bool TryHit(Vector2 position)
    {
        if (_hitBounds.Contains(_camera.ScreenToWorldPoint(position)))
        {
            if (_enemy == null)
            {
                _enemy = _pool.Next();
            }

            return true;
        }
        else
        {
            return false;
        }
    }

    public void HitEnemy(int damage)
    {
        _enemy.ApplyDamage(damage);
    }
}