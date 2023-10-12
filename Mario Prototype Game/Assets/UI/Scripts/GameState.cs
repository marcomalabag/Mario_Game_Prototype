using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private GameObject PauseUI;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GamePause()
    {
        Time.timeScale = 0.0f;
        PauseUI.SetActive(true);
    }

    public void GameResume()
    {
        Time.timeScale = 1.0f;
        PauseUI.SetActive(false);
    }
}
