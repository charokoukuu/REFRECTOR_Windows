using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;


public class loadScene : MonoBehaviour
{
    public void Click()
    {
        if (StaticPlayer.player.clearStage < Now.nowStage)
        {
            StaticPlayer.player.clearStage = Now.nowStage;
            StaticPlayer.savePlayerData(StaticPlayer.player);
        }
        Now.nowStage++;
        FadeManager.Instance.LoadScene("Bound",1.0f);
    }
    public void titleClick()
    {
        StaticPlayer.player.clearStage = Now.nowStage;
        SceneManager.LoadScene("title");
    }
    public void gatya()
    {
        SceneManager.LoadScene("gacha");
    }

}
