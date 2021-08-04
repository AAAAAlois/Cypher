using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoreChoice : MonoBehaviour
{

    public GameObject AllChoice;
    public GameObject Choice1;
    public GameObject Choice2;
    public Text text1;
    public Text text2;
    public string  SecondChoice1;
    public string SecondChoice2;


    public GameObject Answer1a;
    public GameObject Answer1b;
    public GameObject Answer2a;
    public GameObject Answer2b;

    private int time = 1;
    
    //private bool WaitTime;


    //private void Start()
   // {
      //  Choice1.GetComponent<Button>().onClick.AddListener(ClickButton1);
      //  Choice2.GetComponent<Button>().onClick.AddListener(ClickButton2);
   // }


   
    public void ClickButton1()
    {
        //Debug.Log(time);
        time = time + 1;

        if(time == 2)
        {
            Answer1a.SetActive(true);

            text1.text = SecondChoice1;
            text2.text = SecondChoice2;
            //Debug.Log("Set 2nd Choice");
            AllChoice.SetActive(false);

            //AllChoice的生成已经在第二个问题出现后的OnClick调用，注意挂的组件只有唯一一个Choice组件
        }

        if (time == 3)
        {
            Answer2a.SetActive(true);

            //Debug.Log("Set 3nd Choice");
            DestroyImmediate(AllChoice);
        }
    }

    public void ClickButton2()
    {
        time = time + 1;

        if (time == 2)
        {
            Answer1b.SetActive(true);

            text1.text = SecondChoice1;
            text2.text = SecondChoice2;
            //Debug.Log("Set 2nd Choice");
            AllChoice.SetActive(false);
        }

        if (time == 3)
        {
            Answer2b.SetActive(true);

            //Debug.Log("Set 3nd Choice");
            DestroyImmediate(AllChoice);
        }
    }

    public void TimePlus()
    {
        time++;
    }
}
