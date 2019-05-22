using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamChange3 : MonoBehaviour
{
    public Camera cam2;
    public Camera cam3;
    //public GameObject Player1;
    public BoxCollider collider2;
    public CapsuleCollider collider3;
    //public GameObject door2;

    // Use this for initialization
    void Start()
    {
        cam2.enabled = false;
        cam3.enabled = true;
        var collider2 = gameObject.GetComponent<BoxCollider>();
        collider2.isTrigger = true;
        var collider3 = gameObject.GetComponent<CapsuleCollider>();
        collider3.isTrigger = false;
        //var Player1 = gameObject.AddComponent<CapsuleCollider>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider collider2)
    {
        if (collider2.CompareTag("Player"))
        {
            
            //Camera.current.enabled = false;
            cam3.enabled = !cam3.enabled;
            cam2.enabled = !cam2.enabled;
        }
    }
}
