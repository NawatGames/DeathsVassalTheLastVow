using System;
using UnityEngine;

[Serializable]
[System.Flags]
public enum Type
{
    Null = 0,
    Draconideo = 1 << 0,
    Humanoide = 1 << 1,
    Fera = 1 << 2,
    MortoVivo = 1 << 3,
    Monstro = 1 << 4,
    Espirito = 1 << 5
}
