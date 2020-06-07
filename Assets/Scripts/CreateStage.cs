using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CreateStage : MonoBehaviour
{
    public GameObject wall;
    public GameObject basket;
    public GameObject rotateWall;
    public GameObject moveWall;
    public GameObject wall2;
    public int DebugStage;
    Stage stage;
    void Awake()
    {
        if (DebugStage != 200) Now.nowStage=DebugStage;
        stage = loadStageData(Now.nowStage);
    }
    void Start()
    {
        basket.transform.position = stage.basketPos;
        basket.transform.rotation = Quaternion.Euler(stage.basketRot);
        wall2.transform.rotation = Quaternion.Euler(stage.wall2Rot);
        wall.transform.position = stage.wallPos;
        wall2.transform.position = stage.wall2Pos;
        rotateWall.transform.position = stage.RotateWall;
        moveWall.transform.position = stage.MoveWall;


        //aaaaa
        wall.transform.rotation = Quaternion.Euler(stage.wallRot);



    }
    Stage loadStageData(float num)
    {
        string datastr = "";
        StreamReader gameStage;
        if (Application.platform == RuntimePlatform.Android)
        {
            WWW www_load = new WWW(Application.streamingAssetsPath + "/gameStage" + num + ".json");
            while (!www_load.isDone) ;

            byte[] savebytes = www_load.bytes;
            var encode = new System.Text.UTF8Encoding(false);
            string savejson = encode.GetString(savebytes); // BOMを無視する

            return JsonUtility.FromJson<Stage>(savejson);
        }
        else
        {
            try
            {
                gameStage = new StreamReader(Application.streamingAssetsPath + "/gameStage" + num + ".json");
            }

            catch (System.IO.FileNotFoundException ex)
            {
                Stage notStage = new Stage();
                return notStage;

            }
            datastr = gameStage.ReadToEnd();
            gameStage.Close();

            return JsonUtility.FromJson<Stage>(datastr);

        }
    }
}



[System.Serializable]
public class Stage
{
    public Vector3 basketPos;
    public Vector3 basketRot;
    public Vector3 wallPos;
    public Vector3 wallRot;
    public Vector3 wall2Pos;
    public Vector3 wall2Rot;
    public Vector3 RotateWall;
    public Vector3 MoveWall;

    public Stage()
    {
        basketPos = new Vector3(999, 999, 999);
        basketRot = new Vector3(999, 999, 999);
        wallPos = new Vector3(999, 999, 999);
        wall2Pos = new Vector3(999, 999, 999);
        MoveWall = new Vector3(999, 999,999);
            
    }

}
