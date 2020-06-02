using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageLoad : MonoBehaviour
{
    public GameObject numText;
    public GameObject enableButton;
    // Start is called before the first frame update
    void Start()
    {
        int clearStageNum = StaticPlayer.player.clearStage;
        int stageNum = int.Parse(numText.GetComponent<Text>().text);
        if (clearStageNum + 1 < stageNum)
        {
            enableButton.SetActive(false);
        }
    }
    public void click()
    {
        Now.nowStage = int.Parse(numText.GetComponent<Text>().text);
        SceneManager.LoadScene("Bound");
    }
}
