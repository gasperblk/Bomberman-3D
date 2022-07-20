using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stopper : MonoBehaviour
{
    	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "DetectorX") {
			BombSpawner.bs.StopX();
		}
		if (other.gameObject.tag == "DetectorZ") {
			BombSpawner.bs.StopZ();
		}
	}
}
