using UnityEngine;

[CreateAssetMenu(fileName = "Representation", menuName = "Scriptable Objects/Representation")]
public class Representation : ScriptableObject
{
    public new string name;
    public string description;
    public Sprite sprite;
}
