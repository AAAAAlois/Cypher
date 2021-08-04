using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Fungus;

public class Drag : MonoBehaviour,IDragHandler,IBeginDragHandler,IEndDragHandler
{
    public GameObject ThisObject;
    public GameObject correctSpace;
    public GameObject correctOjbect;

    private RectTransform ThisRect;
    private Vector2 StartPos;
    private CanvasGroup canvasGroup;

    public GameObject FinishText;
    public Fungus.Flowchart myflowchart;

    private static int Score = 0;


    // Start is called before the first frame update
    void Start()
    {
        ThisRect = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        //FinishText = GameObject.FindWithTag("FinishText");
        StartPos = ThisRect.anchoredPosition;
    }


    //PointerEventData相当于点击事件的封装，除了检测点击还可以发射射线

    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
        //StartPos = ThisRect.anchoredPosition;
        canvasGroup.blocksRaycasts = false;
        Debug.Log(StartPos);
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
        //Debug.Log(eventData.pointerCurrentRaycast.gameObject.name);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = true;

        if (eventData.pointerCurrentRaycast.gameObject == correctSpace)
        {
            correctOjbect.SetActive(true);

            Score++;

            DestroyImmediate(ThisObject);
           
        }

        else
        {
            ThisRect.anchoredPosition = new Vector2(StartPos.x,StartPos.y);
            Debug.Log(StartPos);
        }

        Debug.Log(Score);

        if(Score == 5)
        {
            FinishText.SetActive(true);
            myflowchart.SetBooleanVariable("DragFinish", true); 
        }
        
    }

    
    
}
