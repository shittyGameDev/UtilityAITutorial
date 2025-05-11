using UnityEngine;

public class NPCController : MonoBehaviour
{
    public MoveController mover { get; set; }
    
    public AIBrain aiBrain { get; set; }
    public Actions[] actionsAvailable;
    
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
}
