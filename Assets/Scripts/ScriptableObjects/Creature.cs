using UnityEngine;

[CreateAssetMenu(fileName = "Creature", menuName = "Scriptable Objects/Creature")]
public class Creature : ScriptableObject
{
    public int Id;
    public Mythology Mythology;
    [SerializeField] private Type type;
    public int XP;

    public Stats Stats;
    public Versus Versus;
    public Representation Representation;
    /*
    public Skill Skill_1;
    public Skill Skill_2;
    public Skill Skill_3;
    public Skill Skill_4;

    public Hook Hooks;
    */

    public Type Type => type;
    
}
