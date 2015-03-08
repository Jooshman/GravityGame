using UnityEngine;
using System.Collections;

public class CreateCubes : MonoBehaviour {
	public Rigidbody cubeFab;
	public Rigidbody doubleCubeFab;
	public Rigidbody point;

	private int clock = 0;
	
	// Update is called once per frame
	void FixedUpdate () {
		clock++;
		if (clock > 23) {

			clock = 0;
			int cubePick = Random.Range(0,8);
			CreateInstance (cubePick);
		} 
	
	}

	private void CreateInstance(int i){
		int chance = Random.Range (0, 5);

		if (i == 0) { //bottom single
			Rigidbody instance = Instantiate (cubeFab, new Vector3 (10, .4f, cubeFab.position.z), cubeFab.rotation) as Rigidbody;
			moveCube (instance);
			if(chance == 0){
				Rigidbody points = Instantiate (point, new Vector3 (10, 3.5f, cubeFab.position.z), point.rotation) as Rigidbody;
				movePoint (points);
			}
		} else if (i == 1) { //high single
			Rigidbody instance = Instantiate (cubeFab, new Vector3 (10, 7, cubeFab.position.z), cubeFab.rotation) as Rigidbody;
			moveCube (instance);
			if(chance == 0){
				Rigidbody points = Instantiate (point, new Vector3 (10, 3.5f, cubeFab.position.z), point.rotation) as Rigidbody;
				movePoint (points);
			}
		} else if (i == 2) { //middle single
			Rigidbody instance = Instantiate (cubeFab, new Vector3 (10, 4, cubeFab.position.z), cubeFab.rotation) as Rigidbody;
			moveCube (instance);
			if(chance == 0){
				if(Random.Range (0,2) == 0){
					Rigidbody points = Instantiate (point, new Vector3 (10, 7f, cubeFab.position.z), point.rotation) as Rigidbody;
					movePoint (points);
				} else{
					Rigidbody points = Instantiate (point, new Vector3 (10, .4f, cubeFab.position.z), point.rotation) as Rigidbody;
					movePoint (points);
				}
			}
		} else if (i == 3) {//low double
			Rigidbody instance = Instantiate (doubleCubeFab, new Vector3 (10, 2, cubeFab.position.z), cubeFab.rotation) as Rigidbody;
			moveCube (instance);
		} else if (i == 4) { //high double
			Rigidbody instance = Instantiate (doubleCubeFab, new Vector3 (10, 5.5f, cubeFab.position.z), cubeFab.rotation) as Rigidbody;
			moveCube (instance);
		} else if (i == 5) { // middle double
			Rigidbody instance = Instantiate (doubleCubeFab, new Vector3 (10, 3.5f, cubeFab.position.z), cubeFab.rotation) as Rigidbody;
			moveCube (instance);
			if(chance == 0){
				if(Random.Range (0,2) == 0){
					Rigidbody points = Instantiate (point, new Vector3 (10, 7f, cubeFab.position.z), point.rotation) as Rigidbody;
					movePoint (points);
				} else{
					Rigidbody points = Instantiate (point, new Vector3 (10, .4f, cubeFab.position.z), point.rotation) as Rigidbody;
					movePoint (points);
				}
			}
	
		} else if (i == 6) { //two singles
			Rigidbody instance = Instantiate (cubeFab, new Vector3 (10, .4f, cubeFab.position.z), cubeFab.rotation) as Rigidbody;
			moveCube (instance);
			if(chance == 0){
				Rigidbody points = Instantiate (point, new Vector3 (10, 3.5f, cubeFab.position.z), point.rotation) as Rigidbody;
				movePoint (points);
			}
			Rigidbody instance2 = Instantiate (cubeFab, new Vector3 (10, 7, cubeFab.position.z), cubeFab.rotation) as Rigidbody;
			moveCube (instance2);
		} else if (i == 7) {
			Rigidbody instance = Instantiate (point, new Vector3 (10, 7, cubeFab.position.z), point.rotation) as Rigidbody;
			movePoint (instance);
		}
	}

	private void moveCube(Rigidbody cube){
		cube.AddForce (new Vector3 (-10,0,0), ForceMode.Impulse);
	}
	private void movePoint(Rigidbody point){
		point.AddForce(new Vector3(-.001f,0,0), ForceMode.Impulse);
	}
}
