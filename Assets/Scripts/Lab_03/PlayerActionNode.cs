using UnityEngine;

public enum PlayerActionType
{
    Move,
    Attack,
    Defend
}

[System.Serializable]
public class NodeOfActionsPlayer
{
    public PlayerActionType Action;

    [Range(10, 30)] public int Life = 15;
    public int Str = 10;
    public int Speed = 10;
    public int Attack = 10;
    public int Defense = 15;

    public Vector3 TargetPosition;

    public NodeOfActionsPlayer Next;

    public NodeOfActionsPlayer(PlayerActionType action, Vector3 targetPosition = default)
    {
        Action = action;
        TargetPosition = targetPosition;
    }

    public void SetNext(NodeOfActionsPlayer next)
    {
        Next = next;
    }
}