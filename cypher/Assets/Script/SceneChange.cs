using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;

//挂在托管上

public class SceneChange: MonoBehaviour
{

    public GameObject guochangObject;
    //public Image guochangImage;
    //public Text guochangText;
    public int FadeTime;
    //public int StandTime;
    public string SceneName;

   

    public void guochang()
    {
        
        guochangObject.SetActive(true);

        //guochangImage.DOFade(1,FadeTime);
        //guochangText.DOFade(1, FadeTime);

        guochangObject.GetComponent<Image>().DOFade(1, FadeTime);
        guochangObject.GetComponentInChildren<Text>().DOFade(1, FadeTime);

    }

    public void OnLoadScene()
    {
        SceneManager.LoadScene(SceneName);
    }

    
}
