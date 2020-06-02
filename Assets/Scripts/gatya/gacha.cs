using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gacha : MonoBehaviour
{
    public AudioClip gatya;
    public AudioClip bon;
    public AudioClip charin;
    AudioSource audio;
    bool singi = false,onclick=true;
    public GameObject gachobj;
    public float z = 2;
    float delta=0;
    public GameObject sphere;
    public int coin = 2000;
    GameObject prefab;
    public  GameObject dialog;
    public Text text;
    probability kakuritu;
    public GameObject okb;
    public GameObject cancelb;
    // Start is called before the first frame update
    void Start()
    {
       
        audio = GetComponent<AudioSource>();
        kakuritu = this.GetComponent<probability>();
      
    }

    // Update is called once per frame
    void Update()
    {
        text.GetComponent<Text>().text = coin.ToString();
        if (Input.GetMouseButtonUp(0)&&coin>=100&&onclick)
        {
            onclick = false;
            dialog.SetActive(true);
            Invoke("button", 0.3f);
        }
        if (singi)
        {
            gachobj.transform.Rotate(0, 0, z);
            delta += z;
            //Debug.Log(kakuritu.random + "," + kakuritu.value);
            if (delta >= 360)
            {

                //prefab.GetComponent<Renderer>().material.color = new Color(255 / 255, 0 / 255, 0 / 255, 255 / 255);
                //prefab.transform.position = new Vector3(0, 1.49f, 0.06f);
               
               
                delta = 0;
                singi = false;
            }
        }
    }

    IEnumerator chari()
    {
        audio.PlayOneShot(charin);

        
        coin -= 100;
        yield return new WaitForSeconds(1);
        audio.PlayOneShot(gatya);
        singi = true;
        kakuritu.rnd();
        yield return new WaitForSeconds(2.5f);
        prefab = Instantiate(kakuritu.result);
        prefab.transform.position = new Vector3(0, 1.49f, 0.06f);
        audio.PlayOneShot(bon);
        onclick = true;
    }
  public void OK()
    {
        dialog.SetActive(false);
        StartCoroutine("chari");
    }
    public void cancel()
    {
        dialog.SetActive(false);
        Invoke("fadeout", 0.2f);
    }
    public void game()
    {
        SceneManager.LoadScene("Bound");
    }
    private void button()
    {
        okb.SetActive(true);
        cancelb.SetActive(true);

    }

    void fadeout()
    {
        onclick = true;
    }
}
