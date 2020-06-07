using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpbound3 : MonoBehaviour
{
    Rigidbody rd;
    // Start is called before the first frame update
    void Start()
    {
        //gameObject.transform.Rotate(0, 0, 0);
        rd = GetComponent<Rigidbody>();
        // rd.rotation = Quaternion.AngleAxis(180, Vector3.up);
        rd.AddForce(2, -2, 0, ForceMode.Impulse);
        Invoke("DestroyDir", 5.5f);
    }

    void DestroyDir()
    {
        Destroy(gameObject);
    }
}