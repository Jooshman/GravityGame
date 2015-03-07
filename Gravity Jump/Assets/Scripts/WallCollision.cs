using UnityEngine;
using System.Collections;

public class WallCollision : MonoBehaviour {

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "cube") {
			Destroy(col.gameObject);
		}
	}
}
