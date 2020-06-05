using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slider : MonoBehaviour
{
    public Slider BGM;
    public Slider SE;
    // Start is called before the first frame update
    void Start()
    {
        if (BGM)
        {
            BGM.value = PlayerPrefs.GetFloat("BGM", 0.5f);
            SE.value = PlayerPrefs.GetFloat("SE", 0.3f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log( PlayerPrefs.GetFloat("SE", 0.5f));
        if (BGM)
        {
            PlayerPrefs.SetFloat("BGM", BGM.value);
            PlayerPrefs.SetFloat("SE", SE.value);
        }
        PlayerPrefs.Save();
        
    }
}
