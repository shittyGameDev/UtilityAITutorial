using UnityEngine;

[CreateAssetMenu(fileName = "HungerConsideration", menuName = "UtilityAI/Considerations/HungerConsideration")]
public class HungerConsideration : Consideration
{
    public override float ScoreConsideration()
    {
        // Example score for hunger consideration
        // This should be replaced with actual logic to determine the NPC's hunger level
        return 0.5f; 
    }
}

