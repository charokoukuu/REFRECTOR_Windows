using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class JsonRead : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        StaticPlayer.player = loadPlayerData();
    }

    public Player loadPlayerData()
    {
        string datastr = "";
        StreamReader reader;
        try
        {
            reader = new StreamReader(Application.persistentDataPath + "/savedata.json");
        }
        catch (System.IO.FileNotFoundException ex)
        {
            Player notPlay = new Player();
            return notPlay;
        }
        datastr = reader.ReadToEnd();
        reader.Close();

        return JsonUtility.FromJson<Player>(datastr);
    }
}
[System.Serializable]
public class Player
{
    public int clearStage;
    public StageInfo[] stageInfos;
    public int[] getBall;
    public int totalCoin;
    public bool gameover,gameclear,settingmenu;
    public Player()
    {
        clearStage = 0;
        stageInfos = null;
        getBall = new int[1] { 1 };
        totalCoin = 0;
        gameover = false;
        gameclear = false;
        settingmenu = false;
    }
}
[System.Serializable]
public class StageInfo
{
    public int getStar;
}

public static class StaticPlayer
{
    public static Player player;
    static StaticPlayer()
    {
        player = new Player();
    }
    static public void savePlayerData(Player player)
    {
        StreamWriter writer;

        string jsonstr = JsonUtility.ToJson(player);

        writer = new StreamWriter(Application.persistentDataPath + "/savedata.json", false);
        writer.Write(jsonstr);
        writer.Flush();
        writer.Close();
    }
}

