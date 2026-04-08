using UnityEngine;

public class PlayerActionLinkedList : MonoBehaviour
{
    public NodeOfActionsPlayer head = null;
    public int Count = 0;

    public void Add(PlayerActionType action, Vector3 targetPosition = default)
    {
        NodeOfActionsPlayer newNode = new NodeOfActionsPlayer(action, targetPosition);

        if (head == null)
        {
            head = newNode;
        }
        else
        {
            NodeOfActionsPlayer current = head;

            while (current.Next != null)
            {
                current = current.Next;
            }

            current.SetNext(newNode);
        }

        Count++;
    }

    public void Clear()
    {
        head = null;
        Count = 0;
    }
}