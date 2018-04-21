using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;

	public She she;

	public float distanceBetweenLines = 1.0f;

	private int time;
	private Rigidbody2D rb;
	private int currentLine = 2;

	void Start ()
	{
		rb = GetComponent<Rigidbody2D>();
		time = 0;

	}


	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		//Vector3 movement = new Vector3 (moveHorizontal,moveVertical, 0.0f);
		//rb.AddForce (movement * speed);

		//Debug.Log ("TIME " + time);

		if((Input.GetKeyDown(KeyCode.UpArrow)) && (currentLine > 1)){
			Vector3 movement = new Vector3 (0.0f, 1.0f, 0.0f);
			Debug.Log ("MOVE UP " + currentLine);
			transform.Translate (movement * speed);
			currentLine--;
		} 
		if((Input.GetKeyDown(KeyCode.DownArrow)) && (currentLine < 3)){
			Vector3 movement = new Vector3 (0.0f, -1.0f, 0.0f);
			Debug.Log ("MOVE DOWN "  + currentLine);
			transform.Translate (movement * speed);
			currentLine++;
		}
		time++;
	}


	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Enemy")
			coll.gameObject.SendMessage("ApplyDamage", 10);
	}
}
