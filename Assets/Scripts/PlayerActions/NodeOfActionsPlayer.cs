using UnityEngine;
using Sirenix.OdinInspector;
using System.Collections.Generic;
public enum PlayerActions
{
    None,
    Attack,
    Defense,
    Move,
}
public class NodeOfActionsPlayer
{ 
    [Range(10, 30)]
    public int Life = 15;
    public int Str = 10;
    public int Speed = 10;
    public int Attack = 10;
    public int Defense = 15;
    public PlayerActions act;
}
