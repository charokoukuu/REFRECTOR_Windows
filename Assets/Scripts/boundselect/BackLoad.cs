using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackLoad : MonoBehaviour
{
    public GameObject setting,bgm,gene,stop;
    AudioSource audioSource;
    public AudioClip clickSE, click2;
    float delta = 0,teisizikan=0;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void click(string value)
    {
        if (value == "setting")
        {
            StaticPlayer.player.settingmenu = true;
            bgm.GetComponent<BgmDirector>().teisi();
            audioSource.PlayOneShot(click2);
            setting.SetActive(true);
        }
        else if (value == "close")
        {
            gene.SetActive(true);
            stop.SetActive(true);
            StaticPlayer.player.settingmenu = false;
            bgm.GetComponent<BgmDirector>().saisei();
            setting.SetActive(false);
        }
        else
        {
            audioSource.PlayOneShot(clickSE);
            // SceneManager.LoadScene("title");
            FadeManager.Instance.LoadScene(value, 1);
        }
    }
    private void Update()
    {
    }
}
