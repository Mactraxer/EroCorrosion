using UnityEngine;

[CreateAssetMenu(fileName = "BlockModel", menuName = "ScriptableObjects/Create BlockModel")]
public class BlockModel : ScriptableObject
{
    [Header("Paramenters")]
    [SerializeField] private int _quantityPoints;
    [SerializeField] private int _count;
    [SerializeField] private ResourceModel _resource;
    [SerializeField] private int _rewardCount;
    [Header("Render")]
    [SerializeField] private Sprite _sprite;

    public int QuantityPoints => _quantityPoints;
    public Sprite Sprite => _sprite;

    public int Count => _count;
    public ResourceModel Resource => _resource;
    public int RewardCount => _rewardCount;
}