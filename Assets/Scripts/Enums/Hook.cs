using System;

[Serializable]
public enum Hook
{
    None = 0,
    OnAttack,
    OnAttacked,
    OnDeath,
    OnTurn,
    OnBuff,
    OnDebuff,
    OnBattleStats
}