using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWall : MonoBehaviour
{
    Stage stage;
    float speed = 5;
    bool judge;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y <= -3.18f)
        {
            judge = false;
        }
        else if (gameObject.transform.position.y >= 3.92f)
        {
            judge = true;

        }
        gameObject.transform.Translate(0, speed, 0);
        if (judge) { speed = -0.05f; } else { speed = 0.05f; };
        Debug.Log(judge);
    }
   
}
