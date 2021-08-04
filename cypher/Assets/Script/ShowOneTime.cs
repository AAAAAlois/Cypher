using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowOneTime : MonoBehaviour
{
   

    private bool canSet = true;
    public GameObject ThisObject;

    //public GameObject one;
    //public GameObject two;


   

    public void OneTime()
    {
        if (canSet == true)
        {
            ThisObject.SetActive(true);
            
            canSet = false;
        }
    }

    public void Delete()
    {
        DestroyImmediate(ThisObject);
    }
}