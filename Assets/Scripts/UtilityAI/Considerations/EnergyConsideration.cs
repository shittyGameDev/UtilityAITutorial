using UnityEngine;

[CreateAssetMenu(fileName = "EnergyConsideration", menuName = "UtilityAI/Considerations/EnergyConsideration")]
public class EnergyConsideration : Consideration
{
    public override float ScoreConsideration()
    {
        return 0.1f;
    }
}
