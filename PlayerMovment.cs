using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour {

    public float speed;
    private Rigidbody rb;
    public Animation movement;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis("Vertical");
        float moveVertical = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(-moveHorizontal * speed, 0f, moveVertical * speed);
        Physics.gravity = new Vector3(10, -9.81F, 10);
        //print(moveHorizontal);
        //print(Player.position);
    }
}
