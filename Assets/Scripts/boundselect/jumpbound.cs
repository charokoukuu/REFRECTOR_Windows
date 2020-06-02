using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpbound : MonoBehaviour
{
    Rigidbody rd;
    // Start is called before the first frame update
    void Start()
    {
        //gameObject.transform.Rotate(0, 0, 0);
        rd = GetComponent<Rigidbody>();
        rd.AddForce(2,-2,0, ForceMode.VelocityChange);
        Invoke("DestroyDir", 1.5f);
    }

   void DestroyDir()
    {
        Destroy(gameObject);
    }
}
