using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBlockCollision : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Score score;

    [SerializeField]
    private int points;

    [SerializeField]
    private int BlockCounter;

    [SerializeField]
    private SpriteRenderer sr; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScoreBlock()
    {
        if(BlockCounter == 0)
        {
            this.sr.color = new Color(165, 42, 42);
        }
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name == "Player" && BlockCounter > 0)
        {
            score.AddScore(points); // Score is a scriptable game object
            BlockCounter--;
            ChangeScoreBlock(); 
        }
    }
}
