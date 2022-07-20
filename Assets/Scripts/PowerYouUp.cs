using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerYouUp : MonoBehaviour
{
	public string function;
	public RawImage SpeedUpImage;
	public RawImage RangeUpImage;

	void Start(){
		 SpeedUpImage.enabled = false;
		 RangeUpImage.enabled = false;
	}

	void OnCollisionEnter (Collision collision) {
		if (collision.gameObject.tag == "Player") {
			Invoke(function, 0);
			Destroy(gameObject);
		}
	}
	
	void RangeUp() {
		BombSpawner.bs.RangeUp();
		RangeUpImage.enabled = true;

	}

	void NextLevel() {
		BombSpawner.bs.NextLevel();
	}

	void SpeedUp() {
		BombSpawner.bs.SpeedUp();
		SpeedUpImage.enabled = true;
	}

	void RangeDown() {
		BombSpawner.bs.RangeDown();
	}

	void SpeedDown() {
		BombSpawner.bs.SpeedDown();
	}
}
