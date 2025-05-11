using System.Collections;
using UnityEngine;

public class NPCController : MonoBehaviour
{
    public MoveController mover { get; set; }
    
    public AIBrain aiBrain { get; set; }
    public Action[] actionsAvailable;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mover = GetComponent<MoveController>();
        aiBrain = GetComponent<AIBrain>();
    }

    // Update is called once per frame
    void Update()
    {
        if(aiBrain.finishedDeciding)
        {
            aiBrain.finishedDeciding = false;
            aiBrain.bestAction.Execute(this);
        }
    }

    public void OnFinishedAction()
    {
        aiBrain.DecideBestAction(actionsAvailable);
    }
    
    #region Coroutines

    public void DoWork(int time)
    {
        StartCoroutine(WorkCoroutine(time));
    }
    
    public void DoSleep(int time)
    {
        StartCoroutine(SleepCoroutine(time));
    }
    
    private IEnumerator WorkCoroutine(int time)
    {
        int counter = time;
        while (counter > 0)
        {
            yield return new WaitForSeconds(1);
            counter--;
        }
        Debug.Log("Work done!");
        OnFinishedAction();
    }
    
    private IEnumerator SleepCoroutine(int time)
    {
        int counter = time;
        while (counter > 0)
        {
            yield return new WaitForSeconds(1);
            counter--;
        }
        Debug.Log("Sleep done!");
        OnFinishedAction();
    }

    #endregion
}
