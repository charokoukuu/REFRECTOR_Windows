using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnd : MonoBehaviour
{
    public GameObject end,stop,gameend,iqfield,gameoverdialog;
    GameObject bgmobj;
    BgmDirector bgm;
    //public GameObject[] stop=new GameObject[2];
    public AudioClip CoinSe, Click, don;
    AudioSource audiosource;
    int coins = 0;
    void Start()
    {
        if (!gameoverdialog)  gameoverdialog.SetActive(false); 
        bgmobj = GameObject.FindGameObjectWithTag("bgm");
        bgm = bgmobj.GetComponent<BgmDirector>();
        audiosource = GetComponent<AudioSource>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "end")
        {
            bgm.teisi();
            StartCoroutine("create");
            Time.timeScale = 1;
            Destroy(gameObject.GetComponent<Rigidbody>());
            //audiosource.PlayOneShot(Click);
        }
        if (other.gameObject.tag == "coin")
        {
            // coins = PlayerPrefs.GetInt("totalcoin", 0);
            audiosource.PlayOneShot(CoinSe);
            Destroy(other.gameObject);
            // Vibra.Vibrate(100);
            coins++;
            // StaticPlayer.player.totalCoin += 1;
            // StaticPlayer.savePlayerData(StaticPlayer.player);
            PlayerPrefs.SetInt("totalcoin", PlayerPrefs.GetInt("totalcoin", 0) + 1);
            PlayerPrefs.Save();

        }
        if (other.gameObject.tag == "wall")
        {
            Debug.Log("don");
            audiosource.PlayOneShot(don);
        }
     
    }
    IEnumerator create()
    {
        yield return new WaitForSeconds(0.1f);
       
        StaticPlayer.player.gameclear = true;
        Destroy(gameObject);
    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("don");
        audiosource.PlayOneShot(don);
    }




    private void Update()
    {
        if (StaticPlayer.player.gameover)
        {
            bgm.teisi();
            Debug.Log("OUT!!!");
            //for(int i = 0; i < stop.Length; i++)
            //{
            //    stop[i].SetActive(false);
            //}
            stop.SetActive(false);
            Time.timeScale = 1;
            gameend.SetActive(true);
            Destroy(gameObject);
            StaticPlayer.player.gameover = false;
            
        }
    }
}
