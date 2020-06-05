using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class background : MonoBehaviour
{
    public GameObject canvas;
    int round=0;
    //public Image img;
    // Start is called before the first frame update
    void Start()
    {
        round = Random.Range(1, 4);
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
