using UnityEngine;

[CreateAssetMenu(fileName = "DigToolModel", menuName = "ScriptableObjects/Create DigToolModel")]
public class DigToolModel : ScriptableObject
{
    [SerializeField] private string _name;
    [SerializeField] private int _damage;

    public string Name => _name;
    public int Damage => _damage;
}