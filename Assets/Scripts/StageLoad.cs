using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageLoad : MonoBehaviour
{
    public GameObject numText, se;
    public GameObject enableButton;
    // Start is called before the first frame update
    void Start()
    {
        se = GameObject.FindGameObjectWithTag("SE");
        float clearStageNum = StaticPlayer.player.clearStage;
        int stageNum = int.Parse(numText.GetComponent<Text>().text);
        if (clearStageNum + 1 < stageNum)
        {
            enableButton.SetActive(false);
        }
    }
    public void click()
    {
        se.GetComponent<SEDirector>().Kirakira();
        Now.nowStage = int.Parse(numText.GetComponent<Text>().text);
        FadeManager.Instance.LoadScene("Bound", 1);
    }
}
