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
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Player Scores");
        score.AddScore(points);
    }
}
