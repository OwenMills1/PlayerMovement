using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamChang5 : MonoBehaviour
{

    //public GameObject cam1;
    //public GameObject cam2;
    public Camera cam1;
    public Camera cam2;
    //public GameObject Player1;
    public BoxCollider collider1;
    public BoxCollider collider2;
    public CapsuleCollider collider3;
    //ublic GameObject Door1;

    // Use this for initialization
    void Start()
    {
        cam1.enabled = true;
        cam2.enabled = false;
        //Door1.SetActive(false);
        var collider1 = gameObject.GetComponent<BoxCollider>();
        var collider2 = gameObject.GetComponent<BoxCollider>();
        collider2.isTrigger = true;
        collider2.enabled = true;
        var collider3 = gameObject.GetComponent<CapsuleCollider>();
        collider3.isTrigger = false;
        var scriptenable = gameObject.GetComponent<GameObject>();
        //var Player1 = gameObject.AddComponent<CapsuleCollider>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider collider1)
    {
        if (collider1.CompareTag("Player"))
        {
            cam1.enabled = !cam1.enabled;
            //Camera.current.enabled = false;
            cam2.enabled = !cam2.enabled;
            collider1.enabled = !collider1.enabled;
            collider2.enabled = !collider2.enabled;
            //Door1.SetActive(true);
        }
    }
}
