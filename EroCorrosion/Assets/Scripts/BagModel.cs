using UnityEngine;

[CreateAssetMenu(fileName = "BagModel", menuName = "ScriptableObjects/Create BagModel")]
public class BagModel : ScriptableObject
{
    [SerializeField] private string _name;
    [SerializeField] private int _capacity;
    [SerializeField] private int _cost;

    public int Capacity => _capacity;
    public string Name => _name;

    public int Cost => _cost;
}