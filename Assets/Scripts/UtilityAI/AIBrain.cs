using UnityEngine;

public class AIBrain : MonoBehaviour
{
    public Action bestAction { get; set; }
    private NPCController npcController;
    public bool finishedDeciding { get; set; }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        npcController = GetComponent<NPCController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bestAction is null)
        {
            DecideBestAction(npcController.actionsAvailable);
        }
    }

    public void DecideBestAction(Action[] actionsAvailable)
    {
        float score = 0f;
        int nextBestIndex = 0;
        for (int i = 0; i < actionsAvailable.Length; i++)
        {
            if(ScoreAction(actionsAvailable[i]) > score)
            {
                nextBestIndex = i;
                score = actionsAvailable[i].score;
            }
        }
        
        bestAction = actionsAvailable[nextBestIndex];
        finishedDeciding = true;
    }
    
    public float ScoreAction(Action action)
    {
        float score = 1f;
        for (int i = 0; i < action.considerations.Length; i++)
        {
            float considerationScore = action.considerations[i].ScoreConsideration();
            score *= considerationScore;

            if (score == 0)
            {
                action.score = 0;
                return action.score;
            }
        }

        float originalScore = score;
        float modFactor = 1 - (1 / action.considerations.Length);
        float makeupValue = (1 - originalScore) * modFactor;
        action.score = originalScore + (makeupValue * originalScore);
        
        return action.score;
    }
}
