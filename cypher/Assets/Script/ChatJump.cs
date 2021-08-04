using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatJump : MonoBehaviour
{
    //public GameObject ThisObject;
    public GameObject JumpDialogue;
    public int time;
    private bool canUpdate = true;

    void Update()
    {
        Jump();
    }

    void Jump()
    {
        if(canUpdate == true)
        {
            JumpDialogue.SetActive(true);
            System.Threading.Thread.Sleep(time);
            canUpdate = false;
        }
    }

  


}
