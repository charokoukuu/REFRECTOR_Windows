using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinText : MonoBehaviour
{
    Text coin;
    void Start()
    {
        // PlayerPrefs.SetInt("totalcoin", 0);
        // PlayerPrefs.Save();
        coin = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        coin.text = PlayerPrefs.GetInt("totalcoin", 0).ToString();
    }
}
