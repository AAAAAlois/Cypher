using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

//挂在3-Clear上

public class ClearChange3 : MonoBehaviour
{
    public Fungus.Flowchart myflowchart;
    public GameObject Camera1;
    public GameObject Camera2;
    public GameObject Camera3;
   
    

    public GameObject Open;
    //public GameObject Clear;


    public Text SceneNumber;
    public Text SceneDescription;

    private float ClearNumber;


    //private void Update()
    //{
    //ClearNumber = myflowchart.GetFloatVariable("ClearChange");
    //Debug.Log(ClearNumber);

    public void OneClick()
    {

        ClearNumber = myflowchart.GetFloatVariable("ClearChange");
        Debug.Log(ClearNumber);

        if (ClearNumber == 1)
            Change(Camera1, Camera2, "Scene 2", "TIPS：督促做好涉密文件、资料的核查和清理，确保如数收回。");

        if (ClearNumber == 2)
            Change(Camera2, Camera3, "Scene 3", "TIPS:由会议主办单位对会议保密工作进行总结，对模范遵守会议保密规定人员予以表扬，对违反会议保密规定的行为及行为人予以批评教育，情节严重的，依照有关保密规定进行严肃处理。");

        if (ClearNumber == 3)
            Change(Camera3, Camera3, "ALL CLEAR", "....已清除所有异常，请及时回复iChat里的消息。所有工作都完成后，点击【开启托管】进入下一阶段。");

    }

    // }



    private void Change(GameObject CameraFrom, GameObject CameraTo, string Number, string Description)
    {
        System.Threading.Thread.Sleep(1000);
        CameraFrom.SetActive(false);
        CameraTo.SetActive(true);

        SceneNumber.text = Number;
        SceneDescription.text = Description;
        Open.SetActive(true);
    }
}
