using UnityEngine;

[CreateAssetMenu(fileName = "Versus", menuName = "Scriptable Objects/Versus")]
public class Versus : ScriptableObject
{

    [SerializeField] private Type weakness;
    [SerializeField] private Type strength;
    [SerializeField] private Type _null;

    public Type Weakness => weakness;
    public Type Strength => strength;
    public Type Null => _null;


}
