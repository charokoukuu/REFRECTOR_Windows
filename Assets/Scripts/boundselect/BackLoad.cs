using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackLoad : MonoBehaviour
{
    // Start is called before the first frame update
    public void click()
    {
        SceneManager.LoadScene("title");
    }
}
