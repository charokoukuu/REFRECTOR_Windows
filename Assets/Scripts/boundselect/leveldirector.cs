using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class leveldirector : MonoBehaviour
{
    GameObject ball;
    public PhysicMaterial bound;
    public Slider boundlevel;
    public Slider scale;
    public Text boundtext;
    public Text scaletext;
    float scalevalue = 0.5f;
    public GameObject ui1;
    public GameObject ui2;
    float level, size;
    // Start is called before the first frame update
    void Start()
    {
        boundtext = ui1.GetComponent<Text>();
        scaletext = ui2.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (Now.nowBall)
        {
            case 1:
                level = 70;
                size = 50;
                break;
            case 2:
                level = 70;
                size = 50;
                break;
            case 3:
                level = 70;
                size = 70;
                break;
            case 4:
                level = 50;
                size = 70;
                break;
            case 5:
                level = 70;
                size = 50;
                break;
            case 6:
                level = 70;
                size = 50;
                break;
            case 7:
                level = 70;
                size = 50;
                break;
            case 8:
                level = 70;
                size = 50;
                break;
            case 9:
                level = 70;
                size = 50;
                break;
        }
        //ball = GameObject.FindGameObjectWithTag("selectball");
        //bound = ball.GetComponent<PhysicMaterial>();
        boundlevel.value =level/100;
        scale.value = size/100;
        boundtext.text= level.ToString();
        scaletext.text= size.ToString();
    }
}
