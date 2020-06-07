using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnd : MonoBehaviour
{
    public GameObject end,stop,gameend,iqfield,gameoverdialog,se,particle;
    GameObject bgmobj;
    BgmDirector bgm;
    //public GameObject[] stop=new GameObject[2];
    public AudioClip CoinSe, Click, don;
    AudioSource audiosource;
    int coins = 0;
    Rigidbody rd;
    void Start()
    {
        rd = GetComponent<Rigidbody>();
        se = GameObject.FindGameObjectWithTag("SE");
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
            particle.GetComponent<ParticleSystem>().Play();
            //audiosource.PlayOneShot(Click);
        }
        if (other.gameObject.tag == "coin")
        {
            // coins = PlayerPrefs.GetInt("totalcoin", 0);
            //audiosource.PlayOneShot(CoinSe);
            se.GetComponent<SEDirector>().Coin();
            Destroy(other.gameObject);
            // Vibra.Vibrate(100);
            coins++;
            // StaticPlayer.player.totalCoin += 1;
            // StaticPlayer.savePlayerData(StaticPlayer.player);
            PlayerPrefs.SetInt("totalcoin", PlayerPrefs.GetInt("totalcoin", 0) + 1);
            PlayerPrefs.Save();

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
        if (collision.gameObject.tag == "wall2")
        {
            se.GetComponent<SEDirector>().Pon();
            Debug.Log("wall2");
            rd.AddForce(6.5f, 0, 0, ForceMode.Impulse);
        }
        else
        {
            se.GetComponent<SEDirector>().Don();
        }
    }




    private void Update()
    {
        if (StaticPlayer.player.gameover)
        {
            se.GetComponent<SEDirector>().Over();
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
