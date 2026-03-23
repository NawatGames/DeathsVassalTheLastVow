using UnityEngine;

[CreateAssetMenu(fileName = "Creature", menuName = "Scriptable Objects/Creature")]
public class Creature : ScriptableObject
{
    public Mythology Mythology;
    [SerializeField] private Type type;
    public int XP;

    public Stats Stats;
    public Versus Versus;
    public Representation Representation;

    public Type Type => type;
    
}
