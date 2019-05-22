using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamChange1 : MonoBehaviour
{

    public Camera cam1;
    public Camera cam2;
    public GameObject VCam1;
    public GameObject VCam2;
    //public GameObject Player1;
    public BoxCollider collider1;
    public CapsuleCollider collider3;

    // Use this for initialization
    void Start()
    {
        cam1.enabled = true;
        cam2.enabled = false;
        var collider1 = gameObject.GetComponent<BoxCollider>();
        collider1.isTrigger = true;
        var collider2 = gameObject.GetComponent<BoxCollider>();
        collider2.isTrigger = true;
        var collider3 = gameObject.GetComponent<CapsuleCollider>();
        collider3.isTrigger = false;
        var VCam1 = gameObject.GetComponent<GameObject>(); ;
        VCam1.SetActive(true);
        var VCam2 = gameObject.GetComponent<GameObject>(); ;
        VCam2.SetActive(false);
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
            cam2.enabled = !cam2.enabled;
            VCam2.SetActive(true);
            VCam1.SetActive(false);
        }
    }
}
