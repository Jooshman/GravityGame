using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour {
	public Text scoreText;
	public Text highScoreText;
	public static int score = 0;
	public static int highScore = 0;
	// Use this for initialization

	void Start () {
		//scoreText = gameObject.GetComponent<Text>();
		//score = 0;
		//scoreText.text = "Score: " + score/2;
		//highScoreText.text = "High Score: " + highScore;
	}

	public int getScore(){
		return score/2;
	}

	public void setScore(int newValue){
		score = newValue;
	}

	public int getHighScore(){
		return highScore;
	}

	public void hitPoints(){
		score += 100;
	}

	public void setHighScore(int newHigh){
		highScore = newHigh;
	}
	// Update is called once per frame
	void FixedUpdate () {
		if (Application.loadedLevel == 2) {
			scoreText.text= "Score: " + getScore ();
			highScoreText.text = "High Score: " + getHighScore();
			return;
		}
		score++;
		scoreText.text = "Score: " + score/2;
		//highScoreText.text = "High Score: " + highScore;
	}

}
