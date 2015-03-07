using UnityEngine;
using System.Collections;

public class CreateCubes : MonoBehaviour {
	public Rigidbody cubeFab;
	public Rigidbody doubleCubeFab;

	private int clock = 0;
	private Random ranGen;
	
	// Update is called once per frame
	void FixedUpdate () {
		clock++;
		if (clock > 30) {

			clock = 0;
			int cubePick = Random.Range(0,7);
			CreateInstance (cubePick);
		} 
	
	}

	private void CreateInstance(int i){
		print (i);
		if (i == 0) { //bottom single
			Rigidbody instance = Instantiate (cubeFab, new Vector3 (10, .4f, cubeFab.position.z), cubeFab.rotation) as Rigidbody;
			moveCube (instance);
		} else if (i == 1) { //high single
			Rigidbody instance = Instantiate (cubeFab, new Vector3 (10, 7, cubeFab.position.z), cubeFab.rotation) as Rigidbody;
			moveCube (instance);
		} else if (i == 2) { //middle single
			Rigidbody instance = Instantiate (cubeFab, new Vector3 (10, 4, cubeFab.position.z), cubeFab.rotation) as Rigidbody;
			moveCube (instance);
		} else if (i == 3) {//low double
			Rigidbody instance = Instantiate (doubleCubeFab, new Vector3 (10, 2, cubeFab.position.z), cubeFab.rotation) as Rigidbody;
			moveCube (instance);
		} else if (i == 4) { //high double
			Rigidbody instance = Instantiate (doubleCubeFab, new Vector3 (10, 5.5f, cubeFab.position.z), cubeFab.rotation) as Rigidbody;
			moveCube (instance);
		} else if (i == 5) { // middle double
			Rigidbody instance = Instantiate (doubleCubeFab, new Vector3 (10, 3.5f, cubeFab.position.z), cubeFab.rotation) as Rigidbody;
			moveCube (instance);
	
		} else if (i == 6) { //two singles
			Rigidbody instance = Instantiate (cubeFab, new Vector3 (10, .4f, cubeFab.position.z), cubeFab.rotation) as Rigidbody;
			moveCube (instance);
			Rigidbody instance2 = Instantiate (cubeFab, new Vector3 (10, 7, cubeFab.position.z), cubeFab.rotation) as Rigidbody;
			moveCube (instance2);
		} 

	}

	private void moveCube(Rigidbody cube){
		cube.AddForce (new Vector3 (-10,0,0), ForceMode.Impulse);
	}
}
