using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class OnLoading : MonoBehaviour
{

    private RectTransform rectComponent;
    private Image imageComp;
    public float speed = 0.0f;
    public GameObject StartGame;

    // Use this for initialization
    void Start()
    {
        rectComponent = GetComponent<RectTransform>();
        imageComp = rectComponent.GetComponent<Image>();
        imageComp.fillAmount = 0.0f;
    }

    void Update()
    {
        if (imageComp.fillAmount != 1f)
        {
            imageComp.fillAmount = imageComp.fillAmount + Time.deltaTime * speed;

        }
        else
        {
            imageComp.fillAmount = 0.0f;
            System.Threading.Thread.Sleep(1000);
            StartGame.SetActive(false);
            Flowchart.BroadcastFungusMessage("开场白");

        }
    }
}
