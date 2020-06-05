using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEDirector : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip clickSE, click2,coin,don,kirakira,clear,over;
    // Start is called before the first frame update

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = PlayerPrefs.GetFloat("SE", 0.3f) ;

    }
    public void Click()
    {
        audioSource.PlayOneShot(clickSE);
    }
    public void Click2()
    {
        audioSource.PlayOneShot(click2);
    }
    public void Coin()
    {
        audioSource.PlayOneShot(coin);
    }
    public void Don()
    {
        audioSource.PlayOneShot(don);
    }
    public void Kirakira()
    {
        audioSource.PlayOneShot(kirakira);
    }
    public void Clear()
    {
        audioSource.PlayOneShot(clear);
    }
    public void Over()
    {
        audioSource.PlayOneShot(over);
    }
    // Update is called once per frame
    void Update()
    {

        audioSource.volume = PlayerPrefs.GetFloat("SE", 0.1f);
    }
}
