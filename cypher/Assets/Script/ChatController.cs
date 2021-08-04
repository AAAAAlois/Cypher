using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Fungus;

public class ChatController : MonoBehaviour
{
    //public string ChatName;
    public string Message;
    public bool Repeat;
    private bool canChat = true;
    

    private void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject()==false)  //判断是否点击在UI上
        {

            //GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value, 1.0f);

            if (Repeat == false)
            {
                if (canChat == true)
                {
                    Flowchart.BroadcastFungusMessage(Message);
                    canChat = false;
                    //Debug.Log("111");
                }
            }

            else
            {
                Flowchart.BroadcastFungusMessage(Message);
                //Debug.Log("222");
            }
        }
        
    }

   
}
