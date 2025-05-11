using UnityEngine;

[CreateAssetMenu(fileName = "MoneyConsideration", menuName = "UtilityAI/Considerations/MoneyConsideration")]
public class MoneyConsideration : Consideration
{
    public override float ScoreConsideration()
    {
        return 0.9f; // Example score for money consideration
    }
}
