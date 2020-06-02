using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StageScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void click()
    {
        SceneManager.LoadScene("stageSelect");

    }

}
