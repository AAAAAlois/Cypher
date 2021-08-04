using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

//挂在2Clear上

public class ClearChange1 : MonoBehaviour
{
    public Fungus.Flowchart myflowchart;
    public GameObject Camera1;
    public GameObject Camera2;
    public GameObject Camera3;
    public GameObject Camera4;
    

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
                Change(Camera1, Camera2, "Scene 2", "TIPS:做好涉密会议文件、资料和其他涉密载体的起草、印制、分发和保管等环节中的保密工作。");

            if (ClearNumber == 2)
                Change(Camera2, Camera3, "Scene 3", "TIPS:对会议住地、会场及其他活动场所的保密环境和将要提供会议使用的通信、办公、扩音设备的保密性能进行安全保密检查。重大涉密会议的场所必须经过权威部门进行技术检测，作出可以使用的结论后方可召开会议。");

            if (ClearNumber == 3)
                Change(Camera3, Camera4, "Scene 4", "TIPS:制定与会人员必须遵守的保密纪律（或保密守则）。");

            if (ClearNumber == 4)
            Change(Camera4, Camera4, "ALL CLEAR", "....已清除所有异常，请及时回复iChat里的消息。所有工作都完成后，点击【开启托管】进入下一阶段。");

            

    }

    


    private void Change(GameObject CameraFrom,GameObject CameraTo,string Number,string Description)
    {
        System.Threading.Thread.Sleep(1000);
        CameraFrom.SetActive(false);
        CameraTo.SetActive(true);

        SceneNumber.text = Number;
        SceneDescription.text = Description;
        Open.SetActive(true);
    }


}

