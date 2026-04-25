using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ActiveSkill", menuName = "Scriptable Objects/ActiveSkill")]
public class ActiveSkill : ScriptableObject
{
    public int ManaCost;
    public bool isAOE; //false single target, true aoe
    public bool isOffensive; //false status, true Offensive
    public Type Type;
    public List<Effect> Effects;
}
