using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class background : MonoBehaviour
{
    public GameObject canvas;
    float round = 0;
    //public Image img;
    // Start is called before the first frame update
    void Start()
    {
        round = Mathf.Ceil(Now.nowStage / 2);
        Debug.Log(round);
        GameObject prefab;
        prefab = Instantiate((GameObject)Resources.Load("images/" + round));
        //img.GetComponent<Image>().sprite = Resources.Load("images" + round);
        prefab.transform.SetParent(canvas.transform, false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
