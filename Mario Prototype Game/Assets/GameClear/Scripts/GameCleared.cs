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

    private void onTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            ObjectiveCleared.Raise();
            Time.timeScale = 0f;
        }
    }
}
