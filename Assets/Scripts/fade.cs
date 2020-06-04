using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fade : MonoBehaviour
{
    float sin = 0;
    float speed = 0.8f;
    float delta = 0;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Image>().color = new Color(255, 255, 255, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
        gameObject.GetComponent<Image>().color = new Color(255, 255, 255, sin/255);
        sin = Mathf.Sin(Time.time*speed);
        sin += 1;
        sin /= 2;
        sin *= 173;
        sin += 82;
        //Debug.Log(sin);


    }
}
