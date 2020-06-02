using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class posget : MonoBehaviour
{
    Vector3 POS1;
    Vector3 POS2;
    public float naiseki = 0;
    public float distance = 0;
    public float kakudo = 0;
    public GameObject cubeprefab;
    GameObject prefab;

    int iqScore = 1600;
    public GameObject iqText;
    // Update is called once per frame

    void Start()
    {
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Destroy(prefab);
            //POS1 = Input.mousePosition;
            POS1 = Camera.main.ScreenToWorldPoint(Input.mousePosition + Camera.main.transform.forward);
            //var pos = Camera.main.ScreenToWorldPoint(Input.mousePosition + Camera.main.transform.forward);
            prefab = Instantiate(cubeprefab);
            POS1.z = 1;

            prefab.transform.position = POS1;
            prefab.transform.localScale = new Vector3(0, 0, 0);
            Time.timeScale = 0.1f;

        }
        else if (Input.GetMouseButtonUp(0))
        {

            //POS2 = Input.mousePosition;
            POS2 = Camera.main.ScreenToWorldPoint(Input.mousePosition + Camera.main.transform.forward);

            naiseki = (POS1.x * POS2.x) + (POS1.y * POS2.y);
            distance = Mathf.Sqrt((POS2.x - POS1.x) * (POS2.x - POS1.x) + (POS2.y - POS1.y) * (POS2.y - POS1.y));
            kakudo = Mathf.Atan2(POS2.y - POS1.y, POS2.x - POS1.x);
            prefab.transform.Rotate(Vector3.forward * kakudo * 180 / Mathf.PI);
            prefab.transform.localScale = new Vector3(distance, 0.2f, 1);
            Debug.Log(kakudo * 180 / Mathf.PI);
            Time.timeScale = 1;

            //prefab.transform.localScale(Vector3.forward * newposx);
        }
        else if (Input.GetMouseButton(0))
        {
            iqScore = iqScore - 3;
            iqText.GetComponent<Text>().text = Mathf.Round(iqScore / 10).ToString();
        }
    }

}