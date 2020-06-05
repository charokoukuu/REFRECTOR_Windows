using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IqBar : MonoBehaviour
{
    public GameObject result;
    public float delta = 0;
    public GameObject iq;
    string difficulty = "hard";
    public int timeValue = 0;
    string chara = "";
    public Text timerText;
    public GameObject timecircle;
    // Start is called before the first frame update
    void Start()
    {
        timecircle.GetComponent<Image>().color = new Color(70f / 255f, 202f / 255f, 101f / 255f, 255f / 255f);
  
        delta = timeValue;

    }

    // Update is called once per frame
    void Update()
    {

        delta = iq.GetComponent<posget>().iqScore;
        delta /= 1600;
        timecircle.GetComponent<Image>().fillAmount =delta;
        if (delta < 0.75&& 0.25 <= delta)
        {
            timecircle.GetComponent<Image>().color = new Color(255 / 255f, 207/ 255f, 0/ 255f, 255/ 255f);
        }
        else if (delta <0.25)
        {
            timecircle.GetComponent<Image>().color = new Color(186f / 255f, 27f / 255f, 24f / 255f, 255f / 255f);
        }
        else if (delta < 0)
        {
            chara = "END";
      

        }
        //chara = delta.ToString("F1") + "s";
   

    }
}

