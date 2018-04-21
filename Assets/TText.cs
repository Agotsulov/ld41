using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TText : MonoBehaviour {

	public string text;
	public float speed;

	private Rigidbody2D rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody2D>();
		Vector3 movement = new Vector3 (-1.0f ,0.0f , 0.0f);
		rb.AddForce (movement * speed);
	}

	void Update () {
		if(transform.position.x < 1000)  
			rb.velocity = Vector3.zero;
	}

	public void setText(string text){
		this.text = text;
		TextMesh tm = GetComponent<TextMesh> ();
		tm.text = text;
	}

	public void movet(float speed){
		Vector3 movement = new Vector3 (-1.0f ,0.0f , 0.0f);
		rb.AddForce (movement * speed);
	}
}
