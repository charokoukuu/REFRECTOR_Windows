using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rotate : MonoBehaviour
{
    public Canvas itemcanvas;
    GameObject PackText;
    public float speed=0;
    public bool inverse;
    int vec = 1;
    public int mode = 0;
    float time=0;
    float sin = 0;
    float neko = 0;
    GameObject aaaa;
    public bool title;
    // Start is called before the first frame update
    void Start()
    {
            vec = inverse? -1 : 1;
        PackText = GameObject.Find("PackName");
    }

    // Update is called once per frame
    void Update()
    {
        if (title)
        {
            time += Time.deltaTime;
            if (PlayerPrefs.GetString("pack", "error") == "error"|| PlayerPrefs.GetString("pack", "error") == "dog")
        {

                PackText.GetComponent<Text>().color = new Color(0.5566038f, 0.1706568f, 0.1706568f, 1);
            }
            else
            {

            PackText.GetComponent<Text>().color = new Color(0, 1, 0.9058404f, 1);
            }
            PackText.GetComponent<Text>().text = PlayerPrefs.GetString("pack", "パック未選択");
            
        }
        if (mode == 0)
        {
              transform.Rotate(0, 0, vec * speed);
        }
        else if(mode==1)
        {
            if (time > 0.89f)
            {
                transform.Rotate(0, 0, vec*speed);
                time = 0;
            }

        }else if (mode == 2)
        {
            var canvasRect = itemcanvas.GetComponent<RectTransform>();

            transform.position =new Vector2(transform.position.x,transform.position.y+2 * sin/2 ) ;
            sin = Mathf.Sin(Time.time);
            //localpoint = new Vector2(-19.2f, 805 + 100 * sin / 2);
            //transform.position = new Vector3(-369, 515+100*sin/6, 0);
           
            
        }
    }
}
