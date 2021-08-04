using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class ClickTutorial : MonoBehaviour
{
    
    public GameObject yichang;
    public GameObject iChat;
    public GameObject Notebook;
    public GameObject Principle;
    public GameObject tuoguan;

    public GameObject Dialogue0;
    public GameObject DialogueYichang;
    public GameObject DialogueIChat;
    public GameObject DialogueNotebook;
    public GameObject DialoguePrinciple;
    public GameObject Dialoguetuoguan;
    public GameObject DialogueStart;

    public GameObject Menu;
    public GameObject Mask;

    public GameObject guochangObject;
    public Image guochangImage;
    public Text guochangText;
    public int FadeTime;
    public string SceneName;

    private float time;

    public void OnMouseDown()
    {
        OnTutorial(time);
        time++;
    }

    private void OnTutorial(float time)
    {
        if(time == 0)
        {
            yichang.transform.parent = Mask.transform;
            Dialogue0.SetActive(false);
            DialogueYichang.SetActive(true);
        }

        if (time == 1)
        {

            yichang.transform.parent = Menu.transform;
            iChat.transform.parent = Mask.transform;

            DialogueYichang.SetActive(false);
            DialogueIChat.SetActive(true);
        }

        if (time == 2)
        {

            iChat.transform.parent = Menu.transform;
            Notebook.transform.parent = Mask.transform;

            DialogueIChat.SetActive(false);
            DialogueNotebook.SetActive(true);
        }

        if (time == 3)
        {

            Notebook.transform.parent = Menu.transform;
            Principle.transform.parent = Mask.transform;

            DialogueNotebook.SetActive(false);
            DialoguePrinciple.SetActive(true);
        }

        if (time == 4)
        {

            Principle.transform.parent = Menu.transform;
            tuoguan.transform.parent = Mask.transform;

            DialoguePrinciple.SetActive(false);
            Dialoguetuoguan.SetActive(true);
        }

        if (time == 5)
        {

            tuoguan.transform.parent = Menu.transform;

            Dialoguetuoguan.SetActive(false);
            DialogueStart.SetActive(true);
        }

        if (time == 6)
        {
            DialogueStart.SetActive(false);
            guochang();
            
        }


    }

    public void guochang()
    {

        guochangObject.SetActive(true);

        guochangImage.DOFade(1, FadeTime);
        guochangText.DOFade(1, FadeTime);

    }

    public void OnLoadScene()
    {
        SceneManager.LoadScene(SceneName);
    }


}
