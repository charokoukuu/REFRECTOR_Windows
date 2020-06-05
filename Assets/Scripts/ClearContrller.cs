using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearContrller : MonoBehaviour
{
    //public AudioClip Click;
   public AudioSource audiosource;
    public GameObject end, stop,button,generate,bgm;
    public RectTransform iq;
    bool judge;
    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        judge = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (StaticPlayer.player.gameclear)
        {
            //Invoke("DelayMethod", 1.0f);
            audiosource.Play();
            StartCoroutine("gene");
        }
        if (judge&& iq.transform.position.y > 568)
        {
            iq.position += new Vector3(0, -5, 0);
        }
        if (StaticPlayer.player.settingmenu)
        {
            //bgm.GetComponent<AudioSource>().Stop();
            stop.SetActive(false);
            generate.SetActive(false);
        }
        else
        {
            //bgm.GetComponent<AudioSource>().Play();
            //stop.SetActive(true);
            //generate.SetActive(true);
        }
    }
    IEnumerator gene()
    {
        yield return new WaitForSeconds(0.5f);
        //audiosource.PlayOneShot(Click);
       
        end.SetActive(true);
        stop.SetActive(false);
        StaticPlayer.player.gameclear = false;
        judge = true;
        yield return new WaitForSeconds(2.0f);
        button.SetActive(true);
    }
    void DelayMethod()
    {
        //audiosource.PlayOneShot(Click);
        end.SetActive(true);
        stop.SetActive(false);
        StaticPlayer.player.gameclear = false;
    }
}
