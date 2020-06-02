﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generate : MonoBehaviour
{
    public GameObject ball;
    float delta = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if (delta > 1.6f)
        {
            GameObject prefab = Instantiate((GameObject)Resources.Load("Ball/" + Now.nowBall));
            prefab.transform.position = new Vector3(-2.49f, 4.82f, 1);
            prefab.AddComponent<jumpbound>();
            prefab.AddComponent<Rigidbody>();
            delta = 0;
        }
    }
}
