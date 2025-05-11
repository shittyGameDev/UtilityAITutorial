using UnityEngine;

public abstract class Consideration : ScriptableObject
{
    public string considerationName;
    private float _score;
    public float score
    {
        get { return _score; }
        set
        {
            this._score = Mathf.Clamp01(value);
        }
    }
    
    public virtual void Awake()
    {
        score = 0;
    }

    public abstract float ScoreConsideration();
}
