using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class don : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip donse;
    public GameObject se;
    // Start is called before the first frame update
    void Start()
    {
        se = GameObject.FindGameObjectWithTag("SE");
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision collision)
    {
        se.GetComponent<SEDirector>().Don();
    }
}
