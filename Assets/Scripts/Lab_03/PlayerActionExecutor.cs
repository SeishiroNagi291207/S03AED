using UnityEngine;

public class PlayerActionExecutor : MonoBehaviour
{
    public PlayerActionLinkedList actionList;
    public Transform player;

    private NodeOfActionsPlayer currentNode;

    private float timer = 0f;
    public float delay = 1f;

    private bool isRunning = false;

    void Start()
    {
        actionList.Add(PlayerActionType.Move, new Vector3(3, 0, 3));
        actionList.Add(PlayerActionType.Attack);
        actionList.Add(PlayerActionType.Defend);
        actionList.Add(PlayerActionType.Move, new Vector3(-3, 0, 2));

        StartExecution();
    }

    void Update()
    {
        if (!isRunning || currentNode == null) return;

        timer += Time.deltaTime;

        if (timer >= delay)
        {
            Execute(currentNode);
            currentNode = currentNode.Next;
            timer = 0f;
        }
    }

    public void StartExecution()
    {
        currentNode = actionList.head;
        isRunning = true;
        timer = 0f;
    }

    void Execute(NodeOfActionsPlayer node)
    {
        Debug.Log("Vida: " + node.Life + " Str: " + node.Str + " Speed: " + node.Speed);

        switch (node.Action)
        {
            case PlayerActionType.Move:

                Vector3 pos = node.TargetPosition;
                pos.y = player.localScale.y / 2f;

                player.position = pos;

                Debug.Log("Move");
                break;

            case PlayerActionType.Attack:
                Debug.Log("Attack: " + node.Attack);
                break;

            case PlayerActionType.Defend:
                Debug.Log("Defense: " + node.Defense);
                break;
        }
    }
}