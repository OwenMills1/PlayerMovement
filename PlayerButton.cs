using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerButton : MonoBehaviour {

    public GameObject player;
    //public GameObject cube;
    public GameObject box1;
    public Canvas button1; 
    public bool enter;
    public bool exit;
    // Use this for initialization
	void Start ()
    {
        //var player = GameObject.FindWithTag("Player");
        var capsuleCollider = gameObject.AddComponent<CapsuleCollider>();
        capsuleCollider.isTrigger = true;
        button1.gameObject.SetActive(false);
        box1.gameObject.SetActive(false);
        //box1.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update ()
    {

	}

    private void OnTriggerEnter(Collider capsuleCollider)
    {        

        if (capsuleCollider.CompareTag("Player"))
        {
            Debug.Log("entered");
            button1.gameObject.SetActive(true);
        }
              
    }

    private void OnTriggerExit(Collider capsuleCollider)
    {
        if (capsuleCollider.CompareTag("Player"))
        {
            Debug.Log("exiting");
            button1.gameObject.SetActive(false);
            box1.gameObject.SetActive(false);
            PCTest.isOpen = false;
        }
    }
}
