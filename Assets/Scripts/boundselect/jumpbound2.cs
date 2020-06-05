using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpbound2 : MonoBehaviour
{
    Rigidbody rd;
    // Start is called before the first frame update
    void Start()
    {
        //gameObject.transform.Rotate(0, 0, 0);
        rd = GetComponent<Rigidbody>();
        rd.AddForce(10, -7, 0, ForceMode.VelocityChange);
        Invoke("DestroyDir", 3.5f);
    }

    void DestroyDir()
    {
        Destroy(gameObject);
    }
}
