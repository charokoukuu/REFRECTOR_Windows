using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BgmDirector : MonoBehaviour
{
    public AudioSource audios;
    float delta = 0, teisizikan = 0;

    // Start is called before the first frame update
    void Start()
    {
        audios = GetComponent<AudioSource>();
        audios.Play();
        audios.volume = PlayerPrefs.GetFloat("BGM", 0.5f);

    }

    // Update is called once per frame
    public void saisei()
    {
        audios.time = teisizikan;
        audios.Play();
    }
    public void teisi()
    {
        teisizikan = delta;
        audios.Stop();

    }
    private void Update()
    {
        // Debug.Log(PlayerPrefs.GetFloat("BGM", 0.5f));
        audios.volume = PlayerPrefs.GetFloat("BGM", 0.1f);
        delta += Time.deltaTime;
    }
}
