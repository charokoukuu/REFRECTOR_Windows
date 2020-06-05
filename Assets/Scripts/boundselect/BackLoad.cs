using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackLoad : MonoBehaviour
{
    public GameObject setting,bgm,gene,stop,se;
    public int mode = 0;
    //AudioSource audioSource;
    //public AudioClip clickSE, click2;
    float delta = 0,teisizikan=0;
    // Start is called before the first frame update
    void Start()
    {
        //se = GameObject.FindGameObjectWithTag("se");
        //audioSource = GetComponent<AudioSource>();
    }
    public void click(string value)
    {
        if (value == "setting")
        {
            StaticPlayer.player.settingmenu = true;
         if(mode==1)   bgm.GetComponent<BgmDirector>().teisi();
            //audioSource.PlayOneShot(click2);
            se.GetComponent<SEDirector>().Click2();
            setting.SetActive(true);
        }
        else if (value == "close")
        {
            if (gene) gene.SetActive(true);
        
            if (stop) stop.SetActive(true);
            StaticPlayer.player.settingmenu = false;
            if (mode == 1) bgm.GetComponent<BgmDirector>().saisei();
            setting.SetActive(false);
        }
        else
        {
            se.GetComponent<SEDirector>().Click();
            //audioSource.PlayOneShot(clickSE);
            // SceneManager.LoadScene("title");
            FadeManager.Instance.LoadScene(value, 1);
        }
    }
    private void Update()
    {
    }
}
