using UnityEngine;

[CreateAssetMenu(fileName = "BlockModel", menuName = "ScriptableObjects/Create BlockModel")]
public class BlockModel : ScriptableObject
{
    [SerializeField] private int _healthPoints;
    [SerializeField] private Sprite _sprite;

    public int HealthPoints => _healthPoints;
    public Sprite Sprite => _sprite;
}