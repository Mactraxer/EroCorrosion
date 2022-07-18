using UnityEngine;

[CreateAssetMenu(fileName = "ResourceModel", menuName = "ScriptableObjects/Create ResourceModel")]
public class ResourceModel : ScriptableObject
{
    [SerializeField] private int _price;
    [SerializeField] private string _name;

    public int Price => _price;
    public string Name => _name;
}