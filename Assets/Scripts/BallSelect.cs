using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSelect : MonoBehaviour
{
    GameObject se;
    // Start is called before the first frame update
    void Start()
    {
        se=GameObject.FindGameObjectWithTag("SE");
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
        se.GetComponent<SEDirector>().Click2();
        Now.nowBall = int.Parse(gameObject.name);
        Vibra.Vibrate(100);
    }
}
