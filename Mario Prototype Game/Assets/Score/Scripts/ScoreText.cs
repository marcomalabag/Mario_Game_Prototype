using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Score currentScore;

    [SerializeField]
    private Text Score;


    void Start()
    {
        OnScoreChanged();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnScoreChanged()
    {
        Score.text = currentScore.Currentscore.ToString();
    }

}
