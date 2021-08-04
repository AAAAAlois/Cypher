using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class OnEnd : MonoBehaviour
{
    public GameObject guochangObject;
    public GameObject BadEnd;
    public GameObject GoodEnd;
    public GameObject PerfectEnd;

    private float FinalScore;

    public void FindSpider()
    {
        FinalScore = PlayerPrefs.GetFloat("Score"); //在按下选择按钮时要SetFloat
        Debug.Log("Final Score = " + FinalScore);

        guochang();

        if (FinalScore >= 8)
            StartCoroutine(Timer(3));
        else
            StartCoroutine(Timer(1));
    }

    public void NotFindSpider()
    {
        FinalScore = PlayerPrefs.GetFloat("Score"); //在按下选择按钮时要SetFloat
        Debug.Log("Final Score = " + FinalScore);

        guochang();

        if (FinalScore >= 8)
            StartCoroutine(Timer(2));
        else
            StartCoroutine(Timer(1));
    }

    public void guochang()
    {
        guochangObject.SetActive(true);
        guochangObject.GetComponent<Image>().DOFade(1, 2);
        guochangObject.GetComponentInChildren<Text>().DOFade(1, 2);
    }

    private IEnumerator Timer(int i)
    {
        yield return new WaitForSeconds(3);

        if (i == 1)
            BadEnd.SetActive(true);

        if (i == 2)
            GoodEnd.SetActive(true);

        if (i == 3)
            PerfectEnd.SetActive(true);

    }

    public void EndGame()
    {
        Application.Quit();
    }
}
