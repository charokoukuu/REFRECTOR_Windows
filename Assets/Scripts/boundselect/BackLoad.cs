using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackLoad : MonoBehaviour
{
    public GameObject setting;
    AudioSource audioSource;
    public AudioClip clickSE, click2;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void click(string value)
    {
        if (value == "setting")
        {
            audioSource.PlayOneShot(click2);
            setting.SetActive(true);
        }
        else if (value == "close")
        {
            setting.SetActive(false);
        }
        else
        {
            audioSource.PlayOneShot(clickSE);
            // SceneManager.LoadScene("title");
            FadeManager.Instance.LoadScene(value, 1);
        }
    }
}
