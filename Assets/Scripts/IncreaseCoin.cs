using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseCoin : MonoBehaviour
{
    public float velocity = 0;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new Vector3(Random.Range(-2.0f, 2.0f), Random.Range(-5.0f, 5.0f), 1);


    }
    void Update()
    {
        this.gameObject.transform.Rotate(0, 0, velocity);
    }
}
