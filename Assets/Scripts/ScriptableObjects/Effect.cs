using UnityEngine;

[CreateAssetMenu(fileName = "Effect", menuName = "Scriptable Objects/Effect")]
public class Effect : ScriptableObject
{
    public Stat Stat;
    public int Power;
    public int SuccessRate;
    public CustomEffectExecutor CustomExec;
}