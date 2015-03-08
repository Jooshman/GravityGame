using UnityEngine;
using System.Collections;

public class BallCollision : MonoBehaviour {
	ScoreCounter scoreCount = new ScoreCounter ();
	// Use this for initialization
	void OnCollisionEnter (Collision collision){
		if (collision.gameObject.tag == "cube") {
			//Destroy (collision.gameObject);

			if (scoreCount.getHighScore () < scoreCount.getScore ()) {
				scoreCount.setHighScore (scoreCount.getScore ());
			}

			Application.LoadLevel (2);
		} else if (collision.gameObject.tag == "Points") {
			Destroy (collision.gameObject);
			scoreCount.hitPoints();
		}


	}
}
