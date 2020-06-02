using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSelect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(StaticPlayer.player.clearStage);
        foreach (int i in StaticPlayer.player.getBall)
        {
            Debug.Log(i);
            if (int.Parse(gameObject.name) == i)
            {
                GameObject thisBall = (GameObject)Resources.Load("Ball/" + gameObject.name);
                GameObject prefab = Instantiate(thisBall, gameObject.transform.position, Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    public void click()
    {
        Now.nowBall = int.Parse(gameObject.name);
        Vibra.Vibrate(100);
    }
}
