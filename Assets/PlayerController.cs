using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;

	private Rigidbody2D rb;
	//private Tranform t;

	private int currentLine = 2;

	void Start ()
	{
		rb = GetComponent<Rigidbody2D>();
	//	t = GetComponent<Transform> ();
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		//Vector3 movement = new Vector3 (moveHorizontal,moveVertical, 0.0f);
		//rb.AddForce (movement * speed);

		if((Input.GetKeyDown(KeyCode.W)) && (currentLine > 1)){
			Vector3 movement = new Vector3 (0.0f, 1.0f, 0.0f);
			Debug.Log ("MOVE UP " + currentLine);
			transform.Translate (movement * speed);
			//rb.AddForce (movement * speed);
			currentLine--;
		}
		if((Input.GetKeyDown(KeyCode.S)) && (currentLine < 3)){
			Vector3 movement = new Vector3 (0.0f, -1.0f, 0.0f);
			Debug.Log ("MOVE DOWN "  + currentLine);
			transform.Translate (movement * speed);
			//rb.AddForce (movement * speed);	
			currentLine++;
		}
	}
}
