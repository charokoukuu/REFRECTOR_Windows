using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;


public class loadScene : MonoBehaviour
{
    public GameObject SE;
    private void Start()
    {
        SE = GameObject.FindGameObjectWithTag("SE");
    }
    public void Click()
    {
        SE.GetComponent<SEDirector>().Kirakira();
        if (StaticPlayer.player.clearStage < Now.nowStage)
        {
            StaticPlayer.player.clearStage = Now.nowStage;
            StaticPlayer.savePlayerData(StaticPlayer.player);
        }
        Now.nowStage++;
        if (Now.nowStage >= 9)
        {
            FadeManager.Instance.LoadScene("title", 1.0f);
        }
        else
        {
            FadeManager.Instance.LoadScene("Bound", 1.0f);
        }
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
