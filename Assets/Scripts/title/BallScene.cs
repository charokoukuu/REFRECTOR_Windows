using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BallScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void click()
    {
        SceneManager.LoadScene("BallSelect");

    }

}
