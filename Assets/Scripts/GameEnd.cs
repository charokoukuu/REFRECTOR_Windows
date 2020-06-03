using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnd : MonoBehaviour
{
    public GameObject end;
    public AudioClip CoinSe, Click, don;
    AudioSource audiosource;
    int coins = 0;
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "end")
        {
            audiosource.PlayOneShot(Click);
            StartCoroutine("create");
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

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("don");
        audiosource.PlayOneShot(don);
    }
    IEnumerator create()
    {
        yield return new WaitForSeconds(0.5f);
        end.SetActive(true);
        Destroy(gameObject);
    }
}
