using UnityEngine;

public class DigTool : MonoBehaviour
{
    [SerializeField] private DigToolModel _model;
    public int Damage => _model.Damage;
}