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
    // Start is called before the first frame update
    void Start()
    {
        boundtext = ui1.GetComponent<Text>();
        scaletext = ui2.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //ball = GameObject.FindGameObjectWithTag("selectball");
        //bound = ball.GetComponent<PhysicMaterial>();
        boundlevel.value = bound.bounciness;
        scale.value = scalevalue;
        boundtext.text= (bound.bounciness*100).ToString();
        scaletext.text= (scalevalue*100).ToString();
        Debug.Log(bound.bounciness * 100);
    }
}
