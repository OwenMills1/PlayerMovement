using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamChange6 : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;
    public Collider collider1;
    public GameObject VCam1;
    public GameObject VCam2;
    public GameObject VCam3;
    public GameObject VCam4;
    public GameObject CamChange1;
    public GameObject CamChange2;

    private void Start()
    {
        /* VCam1.SetActive(false);
        VCam2.SetActive(false);
        VCam3.SetActive(false);
        VCam4.SetActive(false);*/
        var collider1 = gameObject.GetComponent<BoxCollider>();
        collider1.isTrigger = true;
    }

    public void OnTriggerEnter(Collider collider1)
    {
        if (collider1.CompareTag("Player"))
        {
            StartCoroutine(Example());
        }
    }

    IEnumerator Example()
    {
        yield return new WaitForSeconds(0.3f);
        cam1.enabled = !cam1.enabled;
        cam2.enabled = !cam2.enabled;
        VCam1.SetActive(false);
        VCam2.SetActive(true);
        CamChange1.SetActive(true);
        CamChange2.SetActive(false);
    }
}
