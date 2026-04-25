using System;
using UnityEngine;

[Serializable]
[System.Flags]
public enum Stat
{
    None = 0,
    ATK = 1 << 0,
    DEF = 1 << 1,
    HP = 1 << 2,
    SPD = 1 << 3,
    LCK = 1 << 4
}
