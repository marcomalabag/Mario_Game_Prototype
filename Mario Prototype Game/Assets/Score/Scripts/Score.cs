using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Score")]
public class Score : ScriptableObject
{
    private int currentScore = 0;
    private int highScore = 0;
    [SerializeField]
    private GameEvent onScoreChanged;

    [SerializeField]
    private GameEvent onHighScoreChanged;

    public int Currentscore { get { return currentScore; } }

    public int Highscore { get { return highScore; } }

    public void AddScore(int Score)
    {
        currentScore += Score;
        onScoreChanged.Raise();
    }

    public void ResetScore()
    {
        currentScore = 0;
        onScoreChanged.Raise();
    }

    public void NewHighScore()
    {
        if(currentScore > highScore)
        {
            highScore = currentScore;
        }
        onHighScoreChanged.Raise();
    }

}
