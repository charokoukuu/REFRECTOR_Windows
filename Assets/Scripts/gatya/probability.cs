using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class probability : MonoBehaviour
{
    public float random = 0;
    public GameObject[] superrare=new GameObject[2];
    public GameObject[] rare=new GameObject[3];
    public GameObject[] normal=new GameObject[5];
    public GameObject result;
    public int value=0;

    public void rnd()
    {
        random = Random.Range(0, 10);
        Debug.Log(random);
        if (random <= 1) {
            value = Random.Range(0, superrare.Length);
            result = superrare[value];
          
        }else if (random > 1 && random <= 5)
        {
            value = Random.Range(0, rare.Length);
            result = rare[value];
        }else if (random > 5 && random <= 10)
        {
            value = Random.Range(0, normal.Length);
            result = normal[value];
        }
    }
}
