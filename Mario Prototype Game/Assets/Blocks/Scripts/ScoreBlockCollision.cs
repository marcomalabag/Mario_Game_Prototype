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
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name == "Player" && BlockCounter > 0)
        {
            score.AddScore(points);
            BlockCounter--;
        }
    }
}
