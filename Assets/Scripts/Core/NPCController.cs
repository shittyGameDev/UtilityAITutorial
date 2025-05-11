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
        
    }
    
    #region Coroutines

    public void DoWork(int time)
    {
        StartCoroutine(WorkCoroutine(time));
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
    }

    #endregion
}
