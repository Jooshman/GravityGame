using UnityEngine;
using System.Collections;

public class BallCollision : MonoBehaviour {

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "cube") {
			
		}
	}
}
