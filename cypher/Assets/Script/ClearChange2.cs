using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

//挂在2Clear上

public class ClearChange2 : MonoBehaviour
{
    public Fungus.Flowchart myflowchart;
    public GameObject Camera1;
    public GameObject Camera2;
    public GameObject Camera3;
    public GameObject Camera4;
    public GameObject Camera5;

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
                Change(Camera1, Camera2, "Scene 2", "TIPS：按时开启会场的保密技术设备，并保证其正常运行。");

            if (ClearNumber == 2)
                Change(Camera2, Camera3, "Scene 3", "TIPS:对会议场所、住地加强巡视，检查有无违反保密规定、保密纪律的行为和泄密隐患。");

            if (ClearNumber == 3)
                Change(Camera3, Camera4, "Scene 4", "TIPS:以口头或者文字的方式向与会人员宣布会议保密纪律或者保密守则，对与会人员进行保密教育。");

            if (ClearNumber == 4)
            Change(Camera4, Camera5, "Scene 5", "TIPS:对会议设备使用过程中的保密状况进行技术检查监督，发现问题及时解决。");

            if (ClearNumber == 5)
                Change(Camera5, Camera5, "ALL CLEAR", "....已清除所有异常，请及时回复iChat里的消息。所有工作都完成后，点击【开启托管】进入下一阶段。");




    }

   // }
    


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

