using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Request{
	public string[] phrases = new string[3];

	public Request(string[] s){
		phrases = s;
	}
}

public class Generator : MonoBehaviour {

	public TText clonedTText;

	public float interval = 10.0f; 
	public float distanceBetweenLines = 1.0f;

	public Queue requests = new Queue();

	private float nextTime = 0;
	private System.Random rand = new System.Random();

	// Use this for initialization
	void Start () {
		requests.Enqueue(new Request(new string[]{"LOL","BL9AT","PIZDOS"}));
		requests.Enqueue(new Request(new string[]{"LOL","BL9AT","PIZDOS"}));
		requests.Enqueue(new Request(new string[]{"LOL","BL9AT","PIZDOS"}));
		requests.Enqueue(new Request(new string[]{"LOL","BL9AT","PIZDOS"}));
	}


	// Update is called once per frame
	void Update () {
		if (Time.time >= nextTime) {
			nextTime += interval; 
			if (requests.Count > 0) {
				//Debug.Log (((Request) requests.Dequeue ()).phrases.ToString());
				Request request = (Request)requests.Dequeue ();

				int random;
				TText t;
				float pos;

				pos = transform.position.y;
				t = Instantiate (clonedTText , new Vector3 (transform.position.x, pos, 0), Quaternion.identity) as TText;
				random = 2;
				t.setText(request.phrases[random]);
				t.movet (0.05f);

				pos += distanceBetweenLines;
				t = Instantiate (clonedTText , new Vector3 (transform.position.x, pos, 0), Quaternion.identity) as TText;
				random = 0;
				t.setText(request.phrases[random]);
				t.movet (0.05f);

				pos -= 2 * distanceBetweenLines;
				t = Instantiate (clonedTText , new Vector3 (transform.position.x, pos, 0), Quaternion.identity) as TText;
				random = 1;
				t.setText(request.phrases[random]);
				t.movet (0.05f);

				Debug.Log ("Просто сука не хочет работать даунский ебанный юнити");
			}
		}
	}
}
