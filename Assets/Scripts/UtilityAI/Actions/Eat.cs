using UnityEngine;

[CreateAssetMenu(fileName = "Eat", menuName = "UtilityAI/Actions/Eat")]
public class Eat : Action
{
    public override void Execute(NPCController npc)
    {
        Debug.Log("I ate food!");
        npc.OnFinishedAction();
    }
}
