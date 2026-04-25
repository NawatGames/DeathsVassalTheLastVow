using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PassiveSkill", menuName = "Scriptable Objects/PassiveSkill")]
public class PassiveSkill : ScriptableObject
{
    //public TargetCalculator TargetCalculator;
    public bool isOffensive; //false status, true Offensive
    public Type Type;
    public List<Hook> Hooks;
    public List<Effect> Effects;
}
