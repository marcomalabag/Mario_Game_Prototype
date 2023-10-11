using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCleared : MonoBehaviour
{
    [SerializeField]
    private GameEvent ObjectiveCleared;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            ObjectiveCleared.Raise();
            Time.timeScale = 0f;
        }
    }
    
}
