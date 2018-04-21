using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	public float speed;

	private Rigidbody2D rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody2D>();
		Vector3 movement = new Vector3 (-1.0f ,0.0f , 0.0f);
		rb.AddForce (movement * speed);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
