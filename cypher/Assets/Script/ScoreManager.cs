using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private static float Score;

    private void Start()
    {
        ScorePlus();

        SetScore();
    }



    public void ScorePlus()
    {
        Score++;
        Debug.Log("CurrentScore = " + Score);
    }

    public void SetScore()   //挂在过场图片
    {
        PlayerPrefs.SetFloat("Score", Score);
        Debug.Log("Score setted : " + Score);

    }

    public void GetScore()
    {
        Score = PlayerPrefs.GetFloat("Score");
        Debug.Log("All Current Score = " + Score);
    }
}
