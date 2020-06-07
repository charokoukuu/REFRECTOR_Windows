using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadBall : MonoBehaviour
{
  Vector3 pos;
  //void OnCollisionEnter(Collision other)
  //{
  //  if (other.gameObject.tag == "Over")
  //  {
  //    Instantiate(gameObject, pos, Quaternion.identity);
  //    Destroy(gameObject);
  //  }

  //}
  void Start()
  {
    pos = gameObject.transform.position;
    GameObject pre = (GameObject)Resources.Load("Ball/" + Now.nowBall.ToString());
    GameObject prefab = Instantiate(pre, pos, Quaternion.identity);

    prefab.transform.parent = transform;
  }

  void Update()
  {
    if (this.gameObject.transform.position.y < -10|| this.gameObject.transform.position.y > 20)
    {
      Instantiate(gameObject, pos, Quaternion.identity);
      Destroy(gameObject);
    }
  }
}
