using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointCounter : MonoBehaviour
{
	public Text scoreDisplay;

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "DetectorX" || other.gameObject.tag == "DetectorZ") {
			scoreDisplay.text = "+1";
			Destroy(gameObject);
		}
	}
}
