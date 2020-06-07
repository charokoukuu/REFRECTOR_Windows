using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generate2 : MonoBehaviour
{
    public GameObject ball;
    float delta = 0;
    public bool title, judge = false;
    // Start is called before the first frame update
    void Start()
    {
        judge = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (title)
        {
            delta += Time.deltaTime;
            if (judge) { Create("title"); judge = false; }
            if (delta > 5.5f)
            {
                Create("title");
                delta = 0;
            }

        }
        else
        {
            delta += Time.deltaTime;
            if (judge) { Create("ballselect"); judge = false; }
            if (delta > 2.6f)
            {
                Create("ballselect");
                delta = 0;
            }
        }
    }
    void Create(string value)
    {
        if (value == "title")
        {
            GameObject prefab = Instantiate((GameObject)Resources.Load("Ball/" + Now.nowBall));
            prefab.transform.position = new Vector3(-10, 10, 1);
            prefab.AddComponent<jumpbound3>();
            prefab.AddComponent<Rigidbody>();
        }
        else
        {


            GameObject prefab = Instantiate((GameObject)Resources.Load("Ball/" + Now.nowBall));
            prefab.transform.position = new Vector3(2.57f, 0.5f, 1);
            prefab.AddComponent<jumpbound>();
            prefab.AddComponent<Rigidbody>();

        }
    }
}
