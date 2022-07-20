using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoBombHere : MonoBehaviour
{
	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "Kocka" || collision.gameObject.tag == "Unicljiva") {
			Destroy(gameObject);
		}
	}	
}
