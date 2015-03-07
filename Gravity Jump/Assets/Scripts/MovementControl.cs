using UnityEngine;
using System.Collections;
using System.Timers;
using UnityEngine.UI;

public class MovementControl : MonoBehaviour {
	public KeyCode space;
	public const int CEIL_POS = 7;
	public const float FLOOR_POS =  0.6f;
	public bool inAir = false;
	public int gravityClock = 0;
	public int gravity = 1;
	public static int timesPlayed = 1;
	

	void Start(){
		if(timesPlayed == 1){
			Physics.gravity = new Vector3 (0, Physics.gravity.y*2, 0);

		}
		//new CreateCubes(1);
		//GetComponent<Rigidbody> ().AddForce (new Vector3 (-20, 0, 0), ForceMode.Impulse);
		//GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 2f*gravity,0), ForceMode.Impulse);

		//test.transform.position = new Vector3 (-12.93f, 0.38f, 14.47f);
		timesPlayed++;
	}

	void FixedUpdate () {

		//scoreText.text = "Score: " + score;
		if (Input.GetKey (space) && inAir == false) {
			inAir = true;
			if(gravity == -1){
				GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 2f*gravity,0), ForceMode.Impulse);
			}
			else{
				GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 2f*gravity,0), ForceMode.Impulse);
			}
			//GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 2f, 0), ForceMode.Impulse);
		}

		if (Input.GetKey (KeyCode.Return)) {
			Application.LoadLevelAsync(0);
			DontDestroyOnLoad(GameObject.Find("Directional Light"));
			DontDestroyOnLoad(GameObject.Find("Main Camera"));
		}

		if(Input.GetKey(KeyCode.S) && gravityClock > 10){
			//GetComponent<Rigidbody>().useGravity = false;
			Physics.gravity = new Vector3(0,Physics.gravity.y*-1,0);
			gravityClock = 0;
			gravity *= -1;
		}	

		if (GetComponent<Rigidbody> ().position.y < FLOOR_POS || GetComponent<Rigidbody> ().position.y > CEIL_POS)
			inAir = false;
		gravityClock++;
	}
}
