using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class She : MonoBehaviour {



	public int score = 0;
	public int loseScore = -100;
	public int winScore = 100;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (score <= loseScore)
			SceneManager.LoadScene ("Gameover");
		if (score >= winScore)
			SceneManager.LoadScene ("Win");
		
	}

	public void say(string words){
		Debug.Log (words);
	}
}
