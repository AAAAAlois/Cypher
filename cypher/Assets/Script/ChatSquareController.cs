using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatSquareController : MonoBehaviour
{

    public RectTransform rect;
  

    // Start is called before the first frame update
    void Start()
    {
        LayoutRebuilder.ForceRebuildLayoutImmediate(rect);
    }

    // Update is called once per frame
    void Update()
    {
       
        LayoutRebuilder.ForceRebuildLayoutImmediate(rect);

    }

    public void LayoutUpdate()
    {
        LayoutRebuilder.ForceRebuildLayoutImmediate(rect);
        Debug.Log("Updated");

    }
}
