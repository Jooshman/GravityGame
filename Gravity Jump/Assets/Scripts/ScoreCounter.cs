using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour {
	public Text scoreText;
	public int score;
	// Use this for initialization

	void Start () {
		//scoreText = gameObject.GetComponent<Text>();
		score = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		score++;
		scoreText.text = "Score: " + score/2;
	}
}
