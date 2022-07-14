using UnityEngine;

[CreateAssetMenu(fileName = "ResourceModel", menuName = "ScriptableObject/Create ResourceModel")]
public class ResourceModel : ScriptableObject
{
    [SerializeField] private int _prirce;
    [SerializeField] private int _name;

    public int Prirce => _prirce;
    public int Name => _name;
}